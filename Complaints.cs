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

namespace ApartmentMS
{
    public partial class FormComplaints : Form
    {
        public FormComplaints()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        private void FormComplaints_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchDGVComplaints();
                    FetchResdIdsIntoCmbBx();
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
                MessageBox.Show("Pls Fill All Fields..", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        // Generate the Next Numeric Id for the New Complaint (Primary Key)
                        const string selmaxsql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(ComplaintId, 2, LEN(ComplaintId)-1) AS INT)), 0) FROM Complaints";
                        int nextnumid;
                        using (SqlCommand maxcmd = new SqlCommand(selmaxsql, sqlcon))
                        {
                            object res = maxcmd.ExecuteScalar();
                            int maxid = (res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                            nextnumid = maxid + 1;
                        }

                        string insdata = @"Insert Into Complaints (ComplaintId, ResidentId, Description, Status, DateCreate) Values (@compid, @resdid, @desc, @sts, @dtcrt)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            string frmtcompid = $"C{nextnumid:D3}";

                            inscmd.Parameters.AddWithValue("@compid", frmtcompid);
                            inscmd.Parameters.AddWithValue("@resdid", CmbBxResdId.Text.Trim());
                            inscmd.Parameters.AddWithValue("@desc", TxtBxDesc.Text.Trim());
                            inscmd.Parameters.AddWithValue("@sts", CmbBxReslvSts.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtcrt", DTPCompCreate.Value);

                            int ra = inscmd.ExecuteNonQuery();
                            if (ra > 0)
                            {
                                MessageBox.Show("Complaint Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ResetFields();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "CompAdd");
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Pls All All Fields..", "Validation Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string compid = DGVComplaints.CurrentRow.Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show($"Are you Sure to Update Complaint Record: {compid} ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = @"Update Complaints Set ResidentId = @rsdid, Description = @desc, Status = @sts, DateCreate = @dtcrt Where ComplaintId = @compid";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@rsdid", CmbBxResdId.Text.Trim());
                                updcmd.Parameters.AddWithValue("@desc", TxtBxDesc.Text.Trim());
                                updcmd.Parameters.AddWithValue("@sts", CmbBxReslvSts.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dtcrt", DTPCompCreate.Value);
                                updcmd.Parameters.AddWithValue("@compid", compid);

                                int ra = updcmd.ExecuteNonQuery();
                                FetchDGVComplaints();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Complaint Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "CompEdit");
                        }
                    }
                }

            }


        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (CmbBxResdId.SelectedIndex == -1 || getid == 0)
            {
                MessageBox.Show("No Record Selected to Delete..", "Validation Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                string compid = DGVComplaints.CurrentRow.Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show($"Are you Sure to Remove Complaint Record: {compid} ?", "Remove Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Update Complaints Set DateDelete = @dtdel Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@delcmd", DateTime.Today);
                                delcmd.Parameters.AddWithValue("@id", getid);

                                int ra = delcmd.ExecuteNonQuery();
                                FetchDGVComplaints();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Complaint Record Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "CompRemove");
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
        private void DGVComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DGVComplaints.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;
                    CmbBxResdId.Text = row.Cells[2].Value.ToString();
                    TxtBxDesc.Text = row.Cells[3].Value.ToString();
                    CmbBxReslvSts.Text = row.Cells[4].Value.ToString();
                    DTPCompCreate.Value = Convert.ToDateTime(row.Cells[5].Value);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVCompsCellClick");
                }
            }
        }

        #region NormalMethods

        void FetchDGVComplaints()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Id, ComplaintId, ResidentId, Complaints.Description as CompDesc, Complaints.Status as ResolveStatus, DateCreate From Complaints Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVComplaints.DataSource = dt;
                        LbTRC.Text = $"{DGVComplaints.Rows.Count}";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchDGVComplaints");
                }
            }
        }

        void FetchResdIdsIntoCmbBx()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select ResidentId, RsdName From Residents Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            CmbBxResdId.Items.Add(sdr["ResidentId"]);
                        }
                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchResdIds");
                }
            }
        }

        bool CheckEmptyFields()
        {
            if (CmbBxResdId.SelectedIndex == -1 || CmbBxResdId.SelectedIndex == -1 || CmbBxReslvSts.SelectedIndex == -1 || DTPCompCreate.Value == DateTime.MinValue)
            { return true; } 
            return false;
        }
        
        void ResetFields()
        {
            CmbBxResdId.SelectedIndex = -1;
            TxtBxDesc.Clear();
            DTPCompCreate.ResetText();
            CmbBxReslvSts.SelectedIndex = -1;
        }

        #endregion NormalMethods
    }
}
