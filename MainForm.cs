using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
            

        public bool frmclosing = false;
        
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmclosing = true;
            DialogResult dr = MessageBox.Show("Are you Sure to Quit ?\nChanges may not be saved", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();   
            }
            Form1.frm1.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
               

        public void AttachMenuStrip(MenuStrip menu)
        {
            if (menu == null) return;

            // Remove from current parent (if any)
            if (menu.Parent != null)
            {
                Control parent = menu.Parent as Control;
                parent?.Controls.Remove(menu);
            }

            // Add to this form and dock to top
            Controls.Add(menu);
            menu.Dock = DockStyle.Top;
            menu.BringToFront();

            // Wire up all MenuItems recursively
            WireMenuItems(menu.Items);
        }

        private void WireMenuItems(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripMenuItem mi)
                {
                    // avoid duplicate wiring
                    mi.Click -= MenuItems_Click;
                    mi.Click += MenuItems_Click;

                    if (mi.HasDropDownItems)
                        WireMenuItems(mi.DropDownItems);
                }
            }
        }

        FormDashboard frmdash = new FormDashboard();
        FormFlats frmflats = new FormFlats();
        FormResidents frmresd = new FormResidents();
        FormMaintenance frmmaintn = new FormMaintenance();
        FormExpenses frmexpenses = new FormExpenses();
        FormComplaints frmcomplaints = new FormComplaints();

        private void MenuItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = sender as ToolStripMenuItem;

            if (tsm != null)
            {
                switch (tsm.Name)
                {
                    case "TSMDashboard":
                        OpenChildForm(frmdash);
                        break;
                    case "TSMFlats":
                        OpenChildForm(frmflats);
                        break;
                    case "TSMResidents":
                        OpenChildForm(frmresd);
                        break;
                    case "TSMMaintenance":
                        OpenChildForm(frmmaintn);
                        break;
                    case "TSMExpenses":
                        OpenChildForm(frmexpenses);
                        break;
                    case "TSMComplaints":
                        OpenChildForm(frmcomplaints);
                        break;
                    case "TSMLogout":
                        DialogResult dr = MessageBox.Show("Are you Sure to Logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            Form1 frm1 = new Form1();   
                            frm1.Show();
                            Hide();
                        }
                        break;
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (PnlPage.Controls.Count > 0)
            { PnlPage.Controls.RemoveAt(0); }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            PnlPage.Controls.Add(childForm);
            PnlPage.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        
    }
}
