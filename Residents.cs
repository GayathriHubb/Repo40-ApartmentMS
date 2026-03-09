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
using System.Data.SqlClient;

namespace ApartmentMS
{
    public partial class FormResidents : Form
    {
        public FormResidents()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        FormDashboard frmdshbrd = new FormDashboard();

        private void FormResidents_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchDGVResidents();
                    FetchCmbBxFlatNums();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FlatsLoad");
                }
            }
        }

        
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

                        const string selmaxsql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(ResidentId, 2, LEN(ResidentId)-1) AS INT)), 0) FROM Residents";
                        int nextnumid;
                        using (SqlCommand maxcmd = new SqlCommand(selmaxsql, sqlcon))
                        {
                            object res = maxcmd.ExecuteScalar();
                            int maxid = (res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                            nextnumid = maxid + 1;
                        }

                        // Prevent Assigning Two Residents to Same Flat
                        string chkquery = @"Select Count(1) From Residents Where FlatId = @fltid AND IsActive = @actsts";
                        using (SqlCommand cmd = new SqlCommand(chkquery, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@fltid", flatid);
                            cmd.Parameters.AddWithValue("@actsts", true);

                            object res = cmd?.ExecuteScalar();   
                            if (res != DBNull.Value && (int)res > 0)
                            {
                                MessageBox.Show("Resident Exists in this Flat.. Choose a Different Flat", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string insdata = "Insert Into Residents (ResidentId, FlatId, RsdName, PhnNum, MoveInDate, DateInsert) Values (@resdid, @flatid, @ResdName, @PhnNum, @MoveIn, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            string frmtresdid = $"R{nextnumid:D3}";

                            inscmd.Parameters.AddWithValue("@resdid", frmtresdid);
                            inscmd.Parameters.AddWithValue("@flatid", flatid);
                            inscmd.Parameters.AddWithValue("@ResdName", TxtBxResdName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@PhnNum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@MoveIn", DTPMoveIn.Value);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            int ra = inscmd.ExecuteNonQuery();
                            FetchDGVResidents();
                            frmdshbrd.OccupiedFlatsCount();
                            if (ra > 0)
                            {
                                MessageBox.Show("Resident Record Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Resident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "ResdAdd");
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
                string resdid = DGVResidents.CurrentRow.Cells["ResidentId"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Resident Record: {resdid}", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update Residents Set RsdName = @rsdname, PhnNum = @phnnum, MoveInDate = @mvin, IsActive = @actsts Where ResidentId = @rsdid";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@rsdname", TxtBxResdName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                                updcmd.Parameters.AddWithValue("@mvin", DTPMoveIn.Value);
                                updcmd.Parameters.AddWithValue("@actsts", ChkBxActvSts.Checked);
                                updcmd.Parameters.AddWithValue("@rsdid", resdid);

                                int ra = updcmd.ExecuteNonQuery();
                                FetchDGVResidents();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Resident Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();  
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ResdEdit");
                        }
                    }
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxResdName.Text) || getid == 0)
            {
                MessageBox.Show("Pls Select Resident Record to Remove", "Validation Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                string resdid = DGVResidents.CurrentRow.Cells["ResidentId"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Resident Record {resdid} ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Update Residents Set DateDelete = @dtdel Where Id = @id";

                            using (SqlCommand cmd = new SqlCommand(deldata, sqlcon))
                            {
                                cmd.Parameters.AddWithValue("@id", getid);
                                cmd.Parameters.AddWithValue("@dtdel", DateTime.Today);

                                int ra = cmd.ExecuteNonQuery();
                                FetchDGVResidents();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Resident Record Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Remove Resident..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ResdRemove");
                        }
                    }
                }
                
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFields();  
        }

        int getid; string rsdid;
        private void DGVResidents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DGVResidents.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;
                    rsdid = (string)row.Cells[1].Value;
                    TxtBxResdName.Text = row.Cells[3].Value.ToString();
                    MTBPhnNum.Text = row.Cells[4].Value.ToString();
                    DTPMoveIn.Value = Convert.ToDateTime(row.Cells[5].Value);
                    ChkBxActvSts.Checked = Convert.ToBoolean(row.Cells[6].Value);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVResidentsCellClick");
                }
            }
        }

        #region NormalMethods

        void FetchDGVResidents()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                { 
                    sqlcon.Open();
                    string seldata = "Select Id, ResidentId, FlatId, Residents.RsdName as ResdName, PhnNum, MoveInDate, Residents.IsActive as ActiveStatus, DateInsert From Residents Where DateDelete is NULL";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(selcmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            DGVResidents.DataSource = dt;
                            LbTRC.Text = dt.Rows.Count.ToString();  
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "FetchDGVResidents");
            }
        }

        public void FetchCmbBxFlatNums()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();
                    CmbBxFlatInfo.DataSource = null;
                    CmbBxFlatInfo.Items.Clear();
                    
                    string seldata = $"Select FlatId, FlatNumber From Flats Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);   
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        CmbBxFlatInfo.DisplayMember = "FlatNumber";
                        CmbBxFlatInfo.ValueMember = "FlatId";
                        CmbBxFlatInfo.DataSource = dt;
                        CmbBxFlatInfo.SelectedIndex = -1;
                        
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchCmbBxFlatNums");
                }
            }
        }

        bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxResdName.Text) || !MTBPhnNum.MaskCompleted || DTPMoveIn.Value == DateTime.MinValue || CmbBxFlatInfo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill in all Required Fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        void ResetFields()
        {
            MTBPhnNum.Clear();
            TxtBxResdName.Clear();
            DTPMoveIn.ResetText();
            ChkBxActvSts.Checked = false;
            CmbBxFlatInfo.SelectedIndex = -1;
        }


        #endregion NormalMethods

        string flatid;
        private void CmbBxFlatNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBxFlatInfo.SelectedIndex != -1)
            {
                flatid = CmbBxFlatInfo.SelectedValue.ToString(); 
                
            }
        }
    }
}
