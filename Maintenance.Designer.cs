namespace ApartmentMS
{
    partial class FormMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlDGV = new System.Windows.Forms.Panel();
            this.LbTRC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVMaintenance = new System.Windows.Forms.DataGridView();
            this.GrpBxFlats = new System.Windows.Forms.GroupBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NUDPaidAmnt = new System.Windows.Forms.NumericUpDown();
            this.NUDMntAmnt = new System.Windows.Forms.NumericUpDown();
            this.CmbBxPaySts = new System.Windows.Forms.ComboBox();
            this.CmbBxMonth = new System.Windows.Forms.ComboBox();
            this.MTBYear = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBxFlatInfo = new System.Windows.Forms.ComboBox();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaintenance)).BeginInit();
            this.GrpBxFlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPaidAmnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMntAmnt)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDGV
            // 
            this.PnlDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDGV.BackColor = System.Drawing.SystemColors.Desktop;
            this.PnlDGV.Controls.Add(this.LbTRC);
            this.PnlDGV.Controls.Add(this.label7);
            this.PnlDGV.Controls.Add(this.DGVMaintenance);
            this.PnlDGV.Location = new System.Drawing.Point(17, 265);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Size = new System.Drawing.Size(945, 370);
            this.PnlDGV.TabIndex = 3;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbTRC.Location = new System.Drawing.Point(105, 338);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(30, 22);
            this.LbTRC.TabIndex = 4;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(4, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Rows: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVMaintenance
            // 
            this.DGVMaintenance.AllowUserToAddRows = false;
            this.DGVMaintenance.AllowUserToDeleteRows = false;
            this.DGVMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMaintenance.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMaintenance.ColumnHeadersHeight = 34;
            this.DGVMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVMaintenance.EnableHeadersVisualStyles = false;
            this.DGVMaintenance.Location = new System.Drawing.Point(2, 10);
            this.DGVMaintenance.Name = "DGVMaintenance";
            this.DGVMaintenance.ReadOnly = true;
            this.DGVMaintenance.RowHeadersWidth = 40;
            this.DGVMaintenance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVMaintenance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMaintenance.RowTemplate.Height = 28;
            this.DGVMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMaintenance.Size = new System.Drawing.Size(940, 320);
            this.DGVMaintenance.TabIndex = 0;
            this.DGVMaintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMaintenance_CellClick);
            // 
            // GrpBxFlats
            // 
            this.GrpBxFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxFlats.BackColor = System.Drawing.SystemColors.Desktop;
            this.GrpBxFlats.Controls.Add(this.CmbBxFlatInfo);
            this.GrpBxFlats.Controls.Add(this.BtnPay);
            this.GrpBxFlats.Controls.Add(this.label5);
            this.GrpBxFlats.Controls.Add(this.BtnReset);
            this.GrpBxFlats.Controls.Add(this.BtnRemove);
            this.GrpBxFlats.Controls.Add(this.BtnEdit);
            this.GrpBxFlats.Controls.Add(this.BtnAdd);
            this.GrpBxFlats.Controls.Add(this.NUDPaidAmnt);
            this.GrpBxFlats.Controls.Add(this.NUDMntAmnt);
            this.GrpBxFlats.Controls.Add(this.CmbBxPaySts);
            this.GrpBxFlats.Controls.Add(this.CmbBxMonth);
            this.GrpBxFlats.Controls.Add(this.MTBYear);
            this.GrpBxFlats.Controls.Add(this.label6);
            this.GrpBxFlats.Controls.Add(this.label4);
            this.GrpBxFlats.Controls.Add(this.label3);
            this.GrpBxFlats.Controls.Add(this.label2);
            this.GrpBxFlats.Controls.Add(this.label1);
            this.GrpBxFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBxFlats.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxFlats.ForeColor = System.Drawing.Color.Linen;
            this.GrpBxFlats.Location = new System.Drawing.Point(17, 9);
            this.GrpBxFlats.Name = "GrpBxFlats";
            this.GrpBxFlats.Size = new System.Drawing.Size(940, 250);
            this.GrpBxFlats.TabIndex = 2;
            this.GrpBxFlats.TabStop = false;
            this.GrpBxFlats.Text = "Maintenance";
            // 
            // BtnPay
            // 
            this.BtnPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPay.AutoSize = true;
            this.BtnPay.BackColor = System.Drawing.Color.Bisque;
            this.BtnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPay.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnPay.Location = new System.Drawing.Point(94, 200);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(120, 39);
            this.BtnPay.TabIndex = 18;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Flat Id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnReset.Location = new System.Drawing.Point(727, 200);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 39);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.Bisque;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnRemove.Location = new System.Drawing.Point(567, 200);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 39);
            this.BtnRemove.TabIndex = 14;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.BackColor = System.Drawing.Color.Bisque;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEdit.Location = new System.Drawing.Point(407, 200);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 39);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAdd.Location = new System.Drawing.Point(247, 200);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 39);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NUDPaidAmnt
            // 
            this.NUDPaidAmnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NUDPaidAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDPaidAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPaidAmnt.Location = new System.Drawing.Point(642, 82);
            this.NUDPaidAmnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDPaidAmnt.Name = "NUDPaidAmnt";
            this.NUDPaidAmnt.Size = new System.Drawing.Size(180, 34);
            this.NUDPaidAmnt.TabIndex = 11;
            // 
            // NUDMntAmnt
            // 
            this.NUDMntAmnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NUDMntAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDMntAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDMntAmnt.Location = new System.Drawing.Point(642, 35);
            this.NUDMntAmnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDMntAmnt.Name = "NUDMntAmnt";
            this.NUDMntAmnt.Size = new System.Drawing.Size(180, 34);
            this.NUDMntAmnt.TabIndex = 10;
            // 
            // CmbBxPaySts
            // 
            this.CmbBxPaySts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbBxPaySts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxPaySts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxPaySts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxPaySts.FormattingEnabled = true;
            this.CmbBxPaySts.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.CmbBxPaySts.Location = new System.Drawing.Point(642, 128);
            this.CmbBxPaySts.Name = "CmbBxPaySts";
            this.CmbBxPaySts.Size = new System.Drawing.Size(180, 33);
            this.CmbBxPaySts.TabIndex = 8;
            // 
            // CmbBxMonth
            // 
            this.CmbBxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxMonth.FormattingEnabled = true;
            this.CmbBxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CmbBxMonth.Location = new System.Drawing.Point(133, 84);
            this.CmbBxMonth.Name = "CmbBxMonth";
            this.CmbBxMonth.Size = new System.Drawing.Size(220, 33);
            this.CmbBxMonth.TabIndex = 7;
            // 
            // MTBYear
            // 
            this.MTBYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBYear.Location = new System.Drawing.Point(133, 132);
            this.MTBYear.Mask = "0000";
            this.MTBYear.Name = "MTBYear";
            this.MTBYear.Size = new System.Drawing.Size(180, 31);
            this.MTBYear.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(460, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Paid Amount(₹)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(460, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mnt Amount(₹)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(460, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payment Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxFlatInfo
            // 
            this.CmbBxFlatInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbBxFlatInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxFlatInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxFlatInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxFlatInfo.FormattingEnabled = true;
            this.CmbBxFlatInfo.Location = new System.Drawing.Point(133, 36);
            this.CmbBxFlatInfo.Name = "CmbBxFlatInfo";
            this.CmbBxFlatInfo.Size = new System.Drawing.Size(180, 33);
            this.CmbBxFlatInfo.TabIndex = 22;
            // 
            // FormMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.GrpBxFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMaintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.FormMaintenance_Load);
            this.PnlDGV.ResumeLayout(false);
            this.PnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaintenance)).EndInit();
            this.GrpBxFlats.ResumeLayout(false);
            this.GrpBxFlats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPaidAmnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMntAmnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDGV;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVMaintenance;
        private System.Windows.Forms.GroupBox GrpBxFlats;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NUDPaidAmnt;
        private System.Windows.Forms.NumericUpDown NUDMntAmnt;
        private System.Windows.Forms.ComboBox CmbBxPaySts;
        private System.Windows.Forms.ComboBox CmbBxMonth;
        private System.Windows.Forms.MaskedTextBox MTBYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.ComboBox CmbBxFlatInfo;
    }
}