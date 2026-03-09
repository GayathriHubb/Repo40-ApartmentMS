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
using System.Windows.Forms.DataVisualization.Charting;

namespace ApartmentMS
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        ApartmentDal apartmentdal = new ApartmentDal();
        string constring;

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            constring = apartmentdal.GetConnString();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    TotFlatsCount();
                    OccupiedFlatsCount();
                    PendingMntCnt();
                    NetBalance();
                    DispChartData();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FlatsLoad");
                }
            }
        }

        public void TotFlatsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Count(Id) From Flats Where DateDelete is NULL";

                    using (SqlCommand cmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = cmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            LbTotFlatsCnt.Text = $"{res}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotFlatsCnt");
                }
            }
        }

        public void OccupiedFlatsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Count(Id) From Residents Where DateDelete is NULL AND IsActive = @act";

                    using (SqlCommand cmd = new SqlCommand( seldata, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@act", true);
                        object res = cmd.ExecuteScalar();   
                        if (res != DBNull.Value)
                        {
                            LbOcpdFlatsCnt.Text = $"{res}";
                        }
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "OccupiedFlatsCnt");
                }
            }
        }

        public void PendingMntCnt()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select Count(Id) From Maintenance Where PaymentStatus = @pmntsts AND DateDelete is NULL";

                    using (SqlCommand cmd = new SqlCommand(seldata, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@pmntsts", "Unpaid");
                        object res = cmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            LbPndMntCnt.Text = $"{res}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "PendingMntCnt");
                }
            }
        }
        
        public void NetBalance()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select (Select SUM(PaidAmount) From Maintenance Where DateDelete is NULL) - (Select SUM(ExpAmount) From Expenses Where DateDelete is NULL) AS NetBalance";
                    
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();    

                        if (res != DBNull.Value)
                        {
                            LbNetBal.Text = $"{res:F2}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "NetBal");
                }
            }
        }

        public void DispChartData()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = @"Select 'Income' as Type, SUM(PaidAmount) as Amount From Maintenance Where Month = @mnth AND Year = @yr 
                                             UNION ALL 
                                        Select 'Expense' as Type, SUM(ExpAmount) as Amount From Expenses Where Month(ExpDate) = @mnth AND Year(ExpDate) = @yr";

                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                        sqlcmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                        SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);    
                        DataTable dt = new DataTable(); 
                        sda.Fill(dt);

                        Chart1.DataSource = dt;  
                        Chart1.DataBind();

                        Chart1.Series[0].Points.DataBindXY(dt.Rows, "Type", dt.Rows, "Amount");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "ChartData");
                }
            }
        }
    }
}
