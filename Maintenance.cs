using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MethodsFW;

namespace ApartmentMS
{
    public partial class FormMaintenance : Form
    {
        public FormMaintenance()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        FormDashboard frmdshbrd = new FormDashboard();

        private void FormMaintenance_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchDGVMaintenance();
                    FetchCmbBxFlatNums();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "MaintenanceLoad");
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbBxFlatInfo.SelectedIndex == -1 || CmbBxMonth.SelectedIndex == -1 || !MTBYear.MaskCompleted)
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        const string selmaxsql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(MaintenanceId, 2, LEN(MaintenanceId)-1) AS INT)), 0) FROM Maintenance";
                        int nextnumid;
                        using (SqlCommand maxcmd = new SqlCommand(selmaxsql, sqlcon))
                        {
                            object res = maxcmd.ExecuteScalar();
                            int maxid = (res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                            nextnumid = maxid + 1;
                        }

                        // Prevent Inserting Duplicate Month and Year
                        string query = @"Select Count (1) From Maintenance Where Month = @mnth AND Year = @yr";
                        using (SqlCommand selcmd = new SqlCommand(query, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@mnth", CmbBxMonth.Text.Trim());
                            selcmd.Parameters.AddWithValue("@yr", MTBYear.Text.Trim());
                            int rc = 0;
                            object res = selcmd.ExecuteScalar();    

                            if (res != DBNull.Value) { rc = (int)res; }

                            if (rc == 0)
                            {
                                string frmtmntid = $"M{nextnumid:D3}";
                                string insdata = "Insert Into Maintenance (MaintenanceId, FlatId, Month, Year, MntAmount, PaidAmount, PaymentStatus, DateInsert)" +
                                                " Values (@mntid, @fltid, @mnth, @yr, @mnthamnt, @pdamnt, @pymntstus, @dtins)";

                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@mntid", frmtmntid);
                                    inscmd.Parameters.AddWithValue("@fltid", CmbBxFlatInfo.SelectedValue.ToString());
                                    inscmd.Parameters.AddWithValue("@mnth", CmbBxMonth.Text.Trim());
                                    inscmd.Parameters.AddWithValue("@yr", MTBYear.Text);
                                    inscmd.Parameters.AddWithValue("@mnthamnt", NUDMntAmnt.Value);
                                    inscmd.Parameters.AddWithValue("@pdamnt", 0);
                                    inscmd.Parameters.AddWithValue("@pymntstus", "Unpaid");
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    int ra = inscmd.ExecuteNonQuery();
                                    FetchDGVMaintenance();
                                    frmdshbrd.PendingMntCnt();
                                    frmdshbrd.NetBalance();
                                    frmdshbrd.DispChartData();
                                    if (ra > 0)
                                    {
                                        MessageBox.Show("Maintenance Record Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ResetFields();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "MaintenanceAdd");
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (NUDPaidAmnt.Value > NUDMntAmnt.Value)
            {
                MessageBox.Show("Paying Amount is Greater than Monthly Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mntid = DGVMaintenance.CurrentRow.Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show($"Are you Sure to Update Maintenance Record {mntid} ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string upddata = @"Update Maintenance Set Month = @mnth, Year = @yr, MntAmount = @mntamnt, PaidAmount = @pdamnt, PaymentStatus = @pymntstus Where MaintenanceId = @mntid";

                        using (SqlCommand cmd = new SqlCommand(upddata, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@mnth", CmbBxMonth.Text.Trim());
                            cmd.Parameters.AddWithValue("@yr", MTBYear.Text);
                            cmd.Parameters.AddWithValue("@mntamnt", NUDMntAmnt.Value);
                            cmd.Parameters.AddWithValue("@pdamnt", NUDPaidAmnt.Value);
                            cmd.Parameters.AddWithValue("@pymntstus", CmbBxPaySts.Text);
                            cmd.Parameters.AddWithValue("@mntid", mntid);

                            int ra = cmd.ExecuteNonQuery();
                            FetchDGVMaintenance();
                            frmdshbrd.NetBalance();
                            frmdshbrd.DispChartData();  

                            if (ra > 0)
                            {
                                MessageBox.Show("Maintenance Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ResetFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "MaintnceRemove");
                    }
                }
            }
            
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(getid == 0)
            {
                MessageBox.Show("No Record Selected to Remove..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                string mntid = DGVMaintenance.CurrentRow.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure to Remove Maintenance Record {mntid} ?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string remdata = "Update Maintenance Set DateDelete = @dtdel Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(remdata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);
                                delcmd.Parameters.AddWithValue("@id", getid);

                                int ra = delcmd.ExecuteNonQuery();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Maintenance Record Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "MntnceRemove");
                        }
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (NUDPaidAmnt.Value == 0 || CmbBxPaySts.SelectedIndex == -1)
            {
                MessageBox.Show("Incomplete Info..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            if (NUDPaidAmnt.Value > NUDMntAmnt.Value)
            {
                MessageBox.Show("Paying Amount is Greater than Monthly Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string mntid = DGVMaintenance.CurrentRow.Cells[1].Value.ToString();
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string query = @"Update Maintenance Set PaidAmount = @pdamnt, PaymentStatus = @pymntst Where MaintenanceId = @mntid";

                        using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@pdamnt", NUDPaidAmnt.Value);
                            cmd.Parameters.AddWithValue("@pymntst", CmbBxPaySts.Text.Trim());
                            cmd.Parameters.AddWithValue("@mntid", mntid);

                            int ra = cmd.ExecuteNonQuery();
                            FetchDGVMaintenance();
                            frmdshbrd.NetBalance();
                            frmdshbrd.DispChartData();
                            if (ra > 0)
                            {
                                MessageBox.Show("Maintenace Amount Paid Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ResetFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "MntncePay");
                    }
                }
            }
        }

        int getid;
        private void DGVMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DGVMaintenance.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;
                    CmbBxMonth.Text = row.Cells[3].Value.ToString();
                    MTBYear.Text = row.Cells[4].Value.ToString();
                    NUDMntAmnt.Value = Convert.ToDecimal(row.Cells[5].Value.ToString());
                    NUDPaidAmnt.Value = Convert.ToDecimal(row.Cells[6].Value);
                    CmbBxPaySts.Text = row.Cells[7].Value.ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVMaintnceCellClick");
                }
            }
        }


        #region NormalMethods

        void FetchDGVMaintenance()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Id, Maintenance.MaintenanceId as MntnceId, FlatId, Month, Year, MntAmount, PaidAmount, PaymentStatus, DateInsert From Maintenance Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVMaintenance.DataSource = dt;
                        LbTRC.Text = $"{DGVMaintenance.Rows.Count}";
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchDGVMntnce");
                }
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

        void ResetFields()
        {
            CmbBxFlatInfo.SelectedIndex = -1;
            CmbBxMonth.SelectedIndex = -1;
            MTBYear.Clear();
            NUDMntAmnt.Value = 0;
            NUDPaidAmnt.Value = 0;  
            CmbBxPaySts.SelectedIndex = -1; 
        }


        bool CheckEmptyFields()
        {
            if (CmbBxMonth.SelectedIndex == -1 || !MTBYear.MaskCompleted || NUDMntAmnt.Value == 0 || CmbBxPaySts.SelectedIndex == -1)
            { return true; }

            return false;
        }

        #endregion NormalMethods
    }
}
