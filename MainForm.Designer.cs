namespace ApartmentMS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PnlPage = new System.Windows.Forms.Panel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFlats = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMResidents = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMComplaints = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPage
            // 
            this.PnlPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPage.Location = new System.Drawing.Point(0, 34);
            this.PnlPage.Name = "PnlPage";
            this.PnlPage.Size = new System.Drawing.Size(978, 610);
            this.PnlPage.TabIndex = 0;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.OldLace;
            this.MenuStrip1.Font = new System.Drawing.Font("Prata", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDashboard,
            this.TSMFlats,
            this.TSMResidents,
            this.TSMMaintenance,
            this.TSMExpenses,
            this.TSMComplaints,
            this.TSMLogout});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(978, 36);
            this.MenuStrip1.TabIndex = 1;
            // 
            // TSMDashboard
            // 
            this.TSMDashboard.Name = "TSMDashboard";
            this.TSMDashboard.Size = new System.Drawing.Size(124, 30);
            this.TSMDashboard.Text = "&Dashboard";
            this.TSMDashboard.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMFlats
            // 
            this.TSMFlats.Name = "TSMFlats";
            this.TSMFlats.Size = new System.Drawing.Size(72, 30);
            this.TSMFlats.Text = "&Flats";
            this.TSMFlats.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMResidents
            // 
            this.TSMResidents.Name = "TSMResidents";
            this.TSMResidents.Size = new System.Drawing.Size(114, 30);
            this.TSMResidents.Text = "&Residents";
            this.TSMResidents.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMMaintenance
            // 
            this.TSMMaintenance.Name = "TSMMaintenance";
            this.TSMMaintenance.Size = new System.Drawing.Size(141, 30);
            this.TSMMaintenance.Text = "&Maintenance";
            this.TSMMaintenance.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMExpenses
            // 
            this.TSMExpenses.Name = "TSMExpenses";
            this.TSMExpenses.Size = new System.Drawing.Size(111, 30);
            this.TSMExpenses.Text = "&Expenses";
            this.TSMExpenses.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMComplaints
            // 
            this.TSMComplaints.Name = "TSMComplaints";
            this.TSMComplaints.Size = new System.Drawing.Size(128, 30);
            this.TSMComplaints.Text = "&Complaints";
            this.TSMComplaints.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // TSMLogout
            // 
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(90, 30);
            this.TSMLogout.Text = "&Logout";
            this.TSMLogout.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.PnlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Apartment Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlPage;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMDashboard;
        private System.Windows.Forms.ToolStripMenuItem TSMFlats;
        private System.Windows.Forms.ToolStripMenuItem TSMResidents;
        private System.Windows.Forms.ToolStripMenuItem TSMMaintenance;
        private System.Windows.Forms.ToolStripMenuItem TSMExpenses;
        private System.Windows.Forms.ToolStripMenuItem TSMComplaints;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
    }
}