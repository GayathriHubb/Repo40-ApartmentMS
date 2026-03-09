using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::System.Diagnostics;


namespace ApartmentMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MenuStrip1.Visible = false;
            frm1 = this;
        }

        FormMain frmmain = new FormMain();
        public static Form1 frm1;
        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\ApartmentMS\Apartment.mdf;Integrated Security = True";

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) || string.IsNullOrEmpty(TxtBxPswrd.Text))
            {
                MessageBox.Show("Pls Fill Both Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);  
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Users Where Username = @un AND Password = @pswrd";

                        using (SqlCommand cmd = new SqlCommand(seldata, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pswrd", TxtBxPswrd.Text.Trim());

                            int rc = (int)cmd.ExecuteScalar();   
                            if (rc > 0)
                            {
                                frmmain.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Credentials..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                MenuStrip1.Visible = false;
                                PnlSignIn.Visible = true;
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SignIn");
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPswrd.Clear();
            ChkBxPswrd.Checked = false; 
        }

        private void ChkBxPswrd_Click(object sender, EventArgs e)
        {
            TxtBxPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
        
    }
}

        

        
