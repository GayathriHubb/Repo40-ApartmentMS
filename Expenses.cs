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
    public partial class FormExpenses : Form
    {
        public FormExpenses()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        FormDashboard frmdshbrd = new FormDashboard();
        private void FormExpenses_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    FetchDGVExpenses();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"{ex.Message}\n{ex.StackTrace}", "ExpensesLoad");
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

                        // Generate the Next Numeric Id for the ExpenseId (Primary Key)
                        const string selmaxsql = "SELECT ISNULL(MAX(TRY_CAST(SUBSTRING(ExpenseId, 2, LEN(ExpenseId)-1) AS INT)), 0) FROM Expenses";
                        int nextnumid;
                        using (SqlCommand maxcmd = new SqlCommand(selmaxsql, sqlcon))
                        {
                            object res = maxcmd.ExecuteScalar();
                            int maxid = (res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                            nextnumid = maxid + 1;
                        }

                        string insdata = "Insert Into Expenses (ExpenseId, ExpenseName, ExpAmount, ExpDate, DateInsert) Values (@expid, @expnm, @expamnt, @expdt, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            string frmtexpid = $"E{nextnumid:D3}";

                            inscmd.Parameters.AddWithValue("@expid", frmtexpid);
                            inscmd.Parameters.AddWithValue("@expnm", TxtBxExpName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@expamnt", NUDExpAmnt.Value);
                            inscmd.Parameters.AddWithValue("@expdt", DTPExpDate.Value);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            int ra = inscmd.ExecuteNonQuery();
                            FetchDGVExpenses();
                            frmdshbrd.NetBalance();
                            frmdshbrd.DispChartData();  
                            if (ra > 0)
                            {
                                MessageBox.Show("Expense Record Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ResetFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "ExpenseAdd");
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
                string expid = DGVExpenses.CurrentRow.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Expense Record: {expid} ?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string updata = "Update Expenses Set ExpenseName = @expnm, ExpAmount = @expamnt, ExpDate = @expdt Where ExpenseId = @expid";

                            using (SqlCommand updcmd = new SqlCommand(updata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@expnm", TxtBxExpName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@expamnt", NUDExpAmnt.Value);
                                updcmd.Parameters.AddWithValue("@expdt", DTPExpDate.Value);
                                updcmd.Parameters.AddWithValue("@expid", expid);

                                int ra = updcmd.ExecuteNonQuery();
                                FetchDGVExpenses();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Expense Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ExpenseEdit");
                        }
                    }
                }
                
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxExpName.Text) || getid == 0)
            {
                MessageBox.Show("No Record Selected to Delete..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                string expid = DGVExpenses.CurrentRow.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Expense Record: {expid} ?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = @"Update Expenses Set DateDelete = @dtdel Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Now);
                                delcmd.Parameters.AddWithValue("@id", getid);

                                int ra = delcmd.ExecuteNonQuery();
                                FetchDGVExpenses();
                                if (ra > 0)
                                {
                                    MessageBox.Show("Expense Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ResetFields();
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ExpenseRemove");
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
        private void DGVExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = DGVExpenses.Rows[e.RowIndex];

                    getid = (int)row.Cells[0].Value;
                    TxtBxExpName.Text = (string)row.Cells[2].Value;
                    NUDExpAmnt.Value = Convert.ToDecimal(row.Cells[3].Value);
                    DTPExpDate.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVExpensesCellClick");
                    throw;
                }
            }
        }

        #region NormalMethods

        private void FetchDGVExpenses()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Id, ExpenseId, ExpenseName, ExpAmount, ExpDate, DateInsert From Expenses Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVExpenses.DataSource = dt;
                        LbTRC.Text = $"{DGVExpenses.Rows.Count}";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FetchDGVExpenses");
                    throw;
                }
            }
        }

        bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxExpName.Text) || NUDExpAmnt.Value == 0 || DTPExpDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        void ResetFields()
        {
            TxtBxExpName.Clear();
            NUDExpAmnt.Value = 0;
            DTPExpDate.ResetText();
        }

        #endregion NormalMethods
    }
}
