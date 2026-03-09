namespace ApartmentMS
{
    partial class FormComplaints
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
            this.DGVComplaints = new System.Windows.Forms.DataGridView();
            this.GrpBxFlats = new System.Windows.Forms.GroupBox();
            this.CmbBxResdId = new System.Windows.Forms.ComboBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CmbBxReslvSts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPCompCreate = new System.Windows.Forms.DateTimePicker();
            this.TxtBxDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComplaints)).BeginInit();
            this.GrpBxFlats.SuspendLayout();
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
            this.PnlDGV.Controls.Add(this.DGVComplaints);
            this.PnlDGV.Location = new System.Drawing.Point(14, 265);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Size = new System.Drawing.Size(950, 336);
            this.PnlDGV.TabIndex = 7;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbTRC.Location = new System.Drawing.Point(105, 304);
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
            this.label7.Location = new System.Drawing.Point(4, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Rows: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVComplaints
            // 
            this.DGVComplaints.AllowUserToAddRows = false;
            this.DGVComplaints.AllowUserToDeleteRows = false;
            this.DGVComplaints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVComplaints.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVComplaints.ColumnHeadersHeight = 34;
            this.DGVComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVComplaints.EnableHeadersVisualStyles = false;
            this.DGVComplaints.Location = new System.Drawing.Point(2, 5);
            this.DGVComplaints.Name = "DGVComplaints";
            this.DGVComplaints.ReadOnly = true;
            this.DGVComplaints.RowHeadersWidth = 40;
            this.DGVComplaints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVComplaints.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVComplaints.RowTemplate.Height = 28;
            this.DGVComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVComplaints.Size = new System.Drawing.Size(945, 290);
            this.DGVComplaints.TabIndex = 0;
            this.DGVComplaints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVComplaints_CellClick);
            // 
            // GrpBxFlats
            // 
            this.GrpBxFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxFlats.BackColor = System.Drawing.SystemColors.Desktop;
            this.GrpBxFlats.Controls.Add(this.CmbBxResdId);
            this.GrpBxFlats.Controls.Add(this.BtnRemove);
            this.GrpBxFlats.Controls.Add(this.BtnReset);
            this.GrpBxFlats.Controls.Add(this.BtnAdd);
            this.GrpBxFlats.Controls.Add(this.BtnEdit);
            this.GrpBxFlats.Controls.Add(this.CmbBxReslvSts);
            this.GrpBxFlats.Controls.Add(this.label2);
            this.GrpBxFlats.Controls.Add(this.label1);
            this.GrpBxFlats.Controls.Add(this.DTPCompCreate);
            this.GrpBxFlats.Controls.Add(this.TxtBxDesc);
            this.GrpBxFlats.Controls.Add(this.label5);
            this.GrpBxFlats.Controls.Add(this.label6);
            this.GrpBxFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBxFlats.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxFlats.ForeColor = System.Drawing.Color.Linen;
            this.GrpBxFlats.Location = new System.Drawing.Point(14, 9);
            this.GrpBxFlats.Name = "GrpBxFlats";
            this.GrpBxFlats.Size = new System.Drawing.Size(950, 250);
            this.GrpBxFlats.TabIndex = 6;
            this.GrpBxFlats.TabStop = false;
            this.GrpBxFlats.Text = "Complaints";
            // 
            // CmbBxResdId
            // 
            this.CmbBxResdId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbBxResdId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxResdId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxResdId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxResdId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxResdId.FormattingEnabled = true;
            this.CmbBxResdId.Location = new System.Drawing.Point(160, 35);
            this.CmbBxResdId.MaxDropDownItems = 80;
            this.CmbBxResdId.Name = "CmbBxResdId";
            this.CmbBxResdId.Size = new System.Drawing.Size(219, 33);
            this.CmbBxResdId.TabIndex = 5;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.Bisque;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnRemove.Location = new System.Drawing.Point(491, 193);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 39);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnReset.Location = new System.Drawing.Point(642, 193);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 39);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAdd.Location = new System.Drawing.Point(188, 193);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 39);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.BackColor = System.Drawing.Color.Bisque;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEdit.Location = new System.Drawing.Point(339, 193);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 39);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CmbBxReslvSts
            // 
            this.CmbBxReslvSts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbBxReslvSts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxReslvSts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxReslvSts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxReslvSts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxReslvSts.FormattingEnabled = true;
            this.CmbBxReslvSts.Items.AddRange(new object[] {
            "Resolved",
            "Pending"});
            this.CmbBxReslvSts.Location = new System.Drawing.Point(670, 37);
            this.CmbBxReslvSts.Name = "CmbBxReslvSts";
            this.CmbBxReslvSts.Size = new System.Drawing.Size(219, 33);
            this.CmbBxReslvSts.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(499, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Resolve Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Resd Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPCompCreate
            // 
            this.DTPCompCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DTPCompCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPCompCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCompCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCompCreate.Location = new System.Drawing.Point(669, 80);
            this.DTPCompCreate.Name = "DTPCompCreate";
            this.DTPCompCreate.Size = new System.Drawing.Size(220, 31);
            this.DTPCompCreate.TabIndex = 8;
            // 
            // TxtBxDesc
            // 
            this.TxtBxDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDesc.Location = new System.Drawing.Point(160, 79);
            this.TxtBxDesc.Multiline = true;
            this.TxtBxDesc.Name = "TxtBxDesc";
            this.TxtBxDesc.Size = new System.Drawing.Size(300, 100);
            this.TxtBxDesc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Comp Desc";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(498, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Create Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.GrpBxFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComplaints";
            this.Text = "Complaints";
            this.Load += new System.EventHandler(this.FormComplaints_Load);
            this.PnlDGV.ResumeLayout(false);
            this.PnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComplaints)).EndInit();
            this.GrpBxFlats.ResumeLayout(false);
            this.GrpBxFlats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDGV;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVComplaints;
        private System.Windows.Forms.GroupBox GrpBxFlats;
        private System.Windows.Forms.DateTimePicker DTPCompCreate;
        private System.Windows.Forms.TextBox TxtBxDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBxReslvSts;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ComboBox CmbBxResdId;
    }
}