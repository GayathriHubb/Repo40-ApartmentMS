using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::System.Data.SqlClient;

namespace ApartmentMS
{
    public partial class FormFlats : Form
    {
        public FormFlats()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        private void FormFlats_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchDGVFlats();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FlatsLoad");
                }
            }
        }

        FormResidents residents = new FormResidents();
        FormMaintenance maintenance = new FormMaintenance();
        FormDashboard frmdshbrd = new FormDashboard();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        // Generate the Next Numeric Id for the New Flat (Primary Key)
                        const string selmaxsql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(FlatId, 2, LEN(FlatId)-1) AS INT)), 0) FROM Flats";
                        int nextnumid;
                        using (SqlCommand maxcmd = new SqlCommand(selmaxsql, sqlcon))
                        {
                            object res = maxcmd.ExecuteScalar();
                            int maxid = (res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                            nextnumid = maxid + 1;
                        }

                        string checksql = "Select Count(*) From Flats Where FlatNumber = @FlatNum And DateDelete is NULL";
                        using (SqlCommand checkcmd = new SqlCommand(checksql, sqlcon))
                        {
                            checkcmd.Parameters.AddWithValue("@FlatNum", MTBFlatNum.Text);
                            object res = checkcmd.ExecuteScalar();
                            if (res != DBNull.Value && Convert.ToInt32(res) > 0)
                            {
                                MessageBox.Show("A Flat with the same number already exists. Please choose a different number.", "Duplicate Flat Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }
                        }

                        string insdata = "Insert Into Flats (FlatId, FlatNumber, Block, Floor, SquareFeet, MntAmntPerMnth, DateInsert) Values (@flatid, @FlatNum, @Block, @Floor, @SqFt, @MntAmnt, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            string frmtflatid = $"F{nextnumid:D3}"; 

                            inscmd.Parameters.AddWithValue("@flatid", frmtflatid);  
                            inscmd.Parameters.AddWithValue("@FlatNum", MTBFlatNum.Text);
                            inscmd.Parameters.AddWithValue("@Block", CmbBxBlock.SelectedItem.ToString());
                            inscmd.Parameters.AddWithValue("@Floor", CmbBxFloor.SelectedItem.ToString());
                            inscmd.Parameters.AddWithValue("@SqFt", NUDSqFt.Value);
                            inscmd.Parameters.AddWithValue("@MntAmnt", NUDMntAmnt.Value);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today); 

                            int ra = inscmd.ExecuteNonQuery();
                            FetchDGVFlats();
                            residents.FetchCmbBxFlatNums();
                            maintenance.FetchCmbBxFlatNums();
                            frmdshbrd.TotFlatsCount();
                            if (ra > 0)
                            {
                                MessageBox.Show("Flat Record Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Flat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "FlatAdd");
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                return; 
            }
            else
            {
                string flatid = DGVFlats.CurrentRow.Cells["FlatId"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure you want to Update the Flat Record: {flatid}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string chkdupl = "Select Count(*) From Flats Where FlatNumber = @fltnumb AND DateDelete is NULL";

                            using (SqlCommand cmd = new SqlCommand(chkdupl, sqlcon))
                            {
                                cmd.Parameters.AddWithValue("@fltnumb", MTBFlatNum.Text);

                                object res = cmd.ExecuteScalar();   

                                if (res != DBNull.Value && (int)res >= 2)
                                {
                                    MessageBox.Show("Flat Number Already Exists", "Duplicate Flat Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            string updata = "Update Flats Set FlatNumber = @FlatNum, Block = @Block, Floor = @Floor, SquareFeet = @SqFt, MntAmntPerMnth = @MntAmnt, IsDeleted = @DelSts Where FlatId = @fltid";
                            using (SqlCommand upcmd = new SqlCommand(updata, sqlcon))
                            {
                                upcmd.Parameters.AddWithValue("@FlatNum", MTBFlatNum.Text);
                                upcmd.Parameters.AddWithValue("@Block", CmbBxBlock.SelectedItem.ToString());
                                upcmd.Parameters.AddWithValue("@Floor", CmbBxFloor.SelectedItem.ToString());
                                upcmd.Parameters.AddWithValue("@SqFt", NUDSqFt.Value);
                                upcmd.Parameters.AddWithValue("@MntAmnt", NUDMntAmnt.Value);
                                upcmd.Parameters.AddWithValue("@DelSts", ChkBxDelSts.Checked);
                                upcmd.Parameters.AddWithValue("@fltid", flatid);

                                int ra = upcmd.ExecuteNonQuery();
                                FetchDGVFlats();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Flat Record Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Update Flat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "FlatEdit");
                        }
                    }
                }
                
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!MTBFlatNum.MaskCompleted || getid == 0)
            {
                MessageBox.Show("Please Select Flat Record to Remove.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                string flatid = DGVFlats.CurrentRow.Cells["FlatId"].Value.ToString();

                DialogResult dr = MessageBox.Show($"Are you Sure to Remove the Flat Record: {flatid}?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();
                            string deldata = "Update Flats Set DateDelete = @dtdel Where Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);
                                delcmd.Parameters.AddWithValue("@id", getid);
                                int ra = delcmd.ExecuteNonQuery();
                                FetchDGVFlats();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Flat Record Removed Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Remove Flat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "FlatRemove");
                        }
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        int getid;
        private void DGVFlats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DGVFlats.Rows[e.RowIndex];

                    getid = Convert.ToInt32(row.Cells["Id"].Value); 
                    MTBFlatNum.Text = row.Cells["FlatNumber"].Value.ToString();
                    CmbBxBlock.SelectedItem = row.Cells["Block"].Value.ToString();
                    CmbBxFloor.SelectedItem = row.Cells["Floor"].Value.ToString();
                    NUDSqFt.Value = Convert.ToDecimal(row.Cells["SquareFeet"].Value);
                    NUDMntAmnt.Value = Convert.ToDecimal(row.Cells["MonthlyAmount"].Value);
                    ChkBxDelSts.Checked = Convert.ToBoolean(row.Cells["DeleteStatus"].Value);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVFlatsCellClick");
                }
                
            }
        }

        #region NormalMethods

        public void FetchDGVFlats()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    string seldata = "Select Id, FlatId, FlatNumber, Block, Floor, SquareFeet, Flats.MntAmntPerMnth as MonthlyAmount, Flats.IsDeleted as DeleteStatus, DateInsert From Flats Where DateDelete is NULL";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(selcmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DGVFlats.DataSource = dt;

                            LbTRC.Text = dt.Rows.Count.ToString();  
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchDGVFlats");
                }
            }
        }

        bool CheckEmptyFields()
        {
            if (!MTBFlatNum.MaskCompleted || CmbBxBlock.SelectedIndex == -1 || CmbBxFloor.SelectedIndex == -1 || NUDSqFt.Value == 0 || NUDMntAmnt.Value == 0)
            {
                MessageBox.Show("Please Fill in all Required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        void ResetFields()
        {
            MTBFlatNum.Clear();
            CmbBxBlock.SelectedIndex = -1;
            CmbBxFloor.SelectedIndex = -1;
            NUDSqFt.Value = 0;
            NUDMntAmnt.Value = 0;
            ChkBxDelSts.Checked = false;
        }

        #endregion NormalMethods
    }
}
