namespace ApartmentMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFlats = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMResidents = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMComplaints = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbHeading = new System.Windows.Forms.Label();
            this.PnlSignIn = new System.Windows.Forms.Panel();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LbSignIn = new System.Windows.Forms.Label();
            this.TxtBxPswrd = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.PnlSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDashboard,
            this.TSMFlats,
            this.TSMResidents,
            this.TSMMaintenance,
            this.TSMExpenses,
            this.TSMComplaints,
            this.logoutToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(978, 37);
            this.MenuStrip1.TabIndex = 0;
            // 
            // TSMDashboard
            // 
            this.TSMDashboard.Name = "TSMDashboard";
            this.TSMDashboard.Size = new System.Drawing.Size(136, 33);
            this.TSMDashboard.Text = "&Dashboard";
            // 
            // TSMFlats
            // 
            this.TSMFlats.Name = "TSMFlats";
            this.TSMFlats.Size = new System.Drawing.Size(76, 33);
            this.TSMFlats.Text = "&Flats";
            // 
            // TSMResidents
            // 
            this.TSMResidents.Name = "TSMResidents";
            this.TSMResidents.Size = new System.Drawing.Size(123, 33);
            this.TSMResidents.Text = "&Residents";
            // 
            // TSMMaintenance
            // 
            this.TSMMaintenance.Name = "TSMMaintenance";
            this.TSMMaintenance.Size = new System.Drawing.Size(151, 33);
            this.TSMMaintenance.Text = "&Maintenance";
            // 
            // TSMExpenses
            // 
            this.TSMExpenses.Name = "TSMExpenses";
            this.TSMExpenses.Size = new System.Drawing.Size(121, 33);
            this.TSMExpenses.Text = "&Expenses";
            // 
            // TSMComplaints
            // 
            this.TSMComplaints.Name = "TSMComplaints";
            this.TSMComplaints.Size = new System.Drawing.Size(138, 33);
            this.TSMComplaints.Text = "&Complaints";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(96, 33);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // LbHeading
            // 
            this.LbHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LbHeading.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Firebrick;
            this.LbHeading.Location = new System.Drawing.Point(363, 90);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(253, 44);
            this.LbHeading.TabIndex = 1;
            this.LbHeading.Text = "PEARL HAVEN";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSignIn
            // 
            this.PnlSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PnlSignIn.Controls.Add(this.ChkBxPswrd);
            this.PnlSignIn.Controls.Add(this.BtnClear);
            this.PnlSignIn.Controls.Add(this.BtnSignIn);
            this.PnlSignIn.Controls.Add(this.LbSignIn);
            this.PnlSignIn.Controls.Add(this.TxtBxPswrd);
            this.PnlSignIn.Controls.Add(this.TxtBxUsername);
            this.PnlSignIn.Controls.Add(this.label2);
            this.PnlSignIn.Controls.Add(this.label1);
            this.PnlSignIn.Location = new System.Drawing.Point(238, 240);
            this.PnlSignIn.Name = "PnlSignIn";
            this.PnlSignIn.Size = new System.Drawing.Size(503, 302);
            this.PnlSignIn.TabIndex = 2;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.Location = new System.Drawing.Point(350, 167);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(154, 25);
            this.ChkBxPswrd.TabIndex = 3;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = true;
            this.ChkBxPswrd.Click += new System.EventHandler(this.ChkBxPswrd_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Prata", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BtnClear.Location = new System.Drawing.Point(324, 222);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(140, 43);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AutoSize = true;
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Prata", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BtnSignIn.Location = new System.Drawing.Point(54, 222);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(140, 43);
            this.BtnSignIn.TabIndex = 6;
            this.BtnSignIn.Text = "SignIn";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LbSignIn
            // 
            this.LbSignIn.AutoSize = true;
            this.LbSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LbSignIn.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSignIn.ForeColor = System.Drawing.Color.Sienna;
            this.LbSignIn.Location = new System.Drawing.Point(197, 10);
            this.LbSignIn.Name = "LbSignIn";
            this.LbSignIn.Size = new System.Drawing.Size(111, 37);
            this.LbSignIn.TabIndex = 5;
            this.LbSignIn.Text = "SIGNIN";
            this.LbSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxPswrd
            // 
            this.TxtBxPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPswrd.Location = new System.Drawing.Point(205, 130);
            this.TxtBxPswrd.Name = "TxtBxPswrd";
            this.TxtBxPswrd.Size = new System.Drawing.Size(300, 31);
            this.TxtBxPswrd.TabIndex = 4;
            this.TxtBxPswrd.UseSystemPasswordChar = true;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(206, 90);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 31);
            this.TxtBxUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Prata", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.PnlSignIn);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.MenuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Apartment Management";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.PnlSignIn.ResumeLayout(false);
            this.PnlSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMDashboard;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.ToolStripMenuItem TSMFlats;
        private System.Windows.Forms.ToolStripMenuItem TSMResidents;
        private System.Windows.Forms.ToolStripMenuItem TSMMaintenance;
        private System.Windows.Forms.ToolStripMenuItem TSMExpenses;
        private System.Windows.Forms.ToolStripMenuItem TSMComplaints;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel PnlSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBxPswrd;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LbSignIn;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
    }
}

