namespace ApartmentMS
{
    partial class FormFlats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpBxFlats = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NUDMntAmnt = new System.Windows.Forms.NumericUpDown();
            this.NUDSqFt = new System.Windows.Forms.NumericUpDown();
            this.ChkBxDelSts = new System.Windows.Forms.CheckBox();
            this.CmbBxFloor = new System.Windows.Forms.ComboBox();
            this.CmbBxBlock = new System.Windows.Forms.ComboBox();
            this.MTBFlatNum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDGV = new System.Windows.Forms.Panel();
            this.LbTRC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVFlats = new System.Windows.Forms.DataGridView();
            this.GrpBxFlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMntAmnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSqFt)).BeginInit();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlats)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBxFlats
            // 
            this.GrpBxFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxFlats.BackColor = System.Drawing.SystemColors.Desktop;
            this.GrpBxFlats.Controls.Add(this.BtnReset);
            this.GrpBxFlats.Controls.Add(this.BtnRemove);
            this.GrpBxFlats.Controls.Add(this.BtnEdit);
            this.GrpBxFlats.Controls.Add(this.BtnAdd);
            this.GrpBxFlats.Controls.Add(this.NUDMntAmnt);
            this.GrpBxFlats.Controls.Add(this.NUDSqFt);
            this.GrpBxFlats.Controls.Add(this.ChkBxDelSts);
            this.GrpBxFlats.Controls.Add(this.CmbBxFloor);
            this.GrpBxFlats.Controls.Add(this.CmbBxBlock);
            this.GrpBxFlats.Controls.Add(this.MTBFlatNum);
            this.GrpBxFlats.Controls.Add(this.label6);
            this.GrpBxFlats.Controls.Add(this.label5);
            this.GrpBxFlats.Controls.Add(this.label4);
            this.GrpBxFlats.Controls.Add(this.label3);
            this.GrpBxFlats.Controls.Add(this.label2);
            this.GrpBxFlats.Controls.Add(this.label1);
            this.GrpBxFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBxFlats.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxFlats.ForeColor = System.Drawing.Color.Linen;
            this.GrpBxFlats.Location = new System.Drawing.Point(14, 9);
            this.GrpBxFlats.Name = "GrpBxFlats";
            this.GrpBxFlats.Size = new System.Drawing.Size(950, 250);
            this.GrpBxFlats.TabIndex = 0;
            this.GrpBxFlats.TabStop = false;
            this.GrpBxFlats.Text = "Flats";
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnReset.Location = new System.Drawing.Point(678, 200);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 39);
            this.BtnReset.TabIndex = 4;
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
            this.BtnRemove.Location = new System.Drawing.Point(518, 200);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 39);
            this.BtnRemove.TabIndex = 3;
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
            this.BtnEdit.Location = new System.Drawing.Point(358, 200);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 39);
            this.BtnEdit.TabIndex = 2;
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
            this.BtnAdd.Location = new System.Drawing.Point(198, 200);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 39);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NUDMntAmnt
            // 
            this.NUDMntAmnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NUDMntAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDMntAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDMntAmnt.Location = new System.Drawing.Point(691, 92);
            this.NUDMntAmnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDMntAmnt.Name = "NUDMntAmnt";
            this.NUDMntAmnt.Size = new System.Drawing.Size(180, 34);
            this.NUDMntAmnt.TabIndex = 9;
            // 
            // NUDSqFt
            // 
            this.NUDSqFt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NUDSqFt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDSqFt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSqFt.Location = new System.Drawing.Point(691, 36);
            this.NUDSqFt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDSqFt.Name = "NUDSqFt";
            this.NUDSqFt.Size = new System.Drawing.Size(180, 34);
            this.NUDSqFt.TabIndex = 8;
            // 
            // ChkBxDelSts
            // 
            this.ChkBxDelSts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChkBxDelSts.AutoSize = true;
            this.ChkBxDelSts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkBxDelSts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxDelSts.Location = new System.Drawing.Point(629, 154);
            this.ChkBxDelSts.Name = "ChkBxDelSts";
            this.ChkBxDelSts.Size = new System.Drawing.Size(22, 21);
            this.ChkBxDelSts.TabIndex = 10;
            this.ChkBxDelSts.UseVisualStyleBackColor = true;
            // 
            // CmbBxFloor
            // 
            this.CmbBxFloor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbBxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxFloor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxFloor.FormattingEnabled = true;
            this.CmbBxFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CmbBxFloor.Location = new System.Drawing.Point(133, 146);
            this.CmbBxFloor.Name = "CmbBxFloor";
            this.CmbBxFloor.Size = new System.Drawing.Size(180, 33);
            this.CmbBxFloor.TabIndex = 7;
            // 
            // CmbBxBlock
            // 
            this.CmbBxBlock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbBxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxBlock.FormattingEnabled = true;
            this.CmbBxBlock.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.CmbBxBlock.Location = new System.Drawing.Point(133, 91);
            this.CmbBxBlock.Name = "CmbBxBlock";
            this.CmbBxBlock.Size = new System.Drawing.Size(180, 33);
            this.CmbBxBlock.TabIndex = 6;
            // 
            // MTBFlatNum
            // 
            this.MTBFlatNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MTBFlatNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBFlatNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBFlatNum.Location = new System.Drawing.Point(133, 35);
            this.MTBFlatNum.Mask = "000";
            this.MTBFlatNum.Name = "MTBFlatNum";
            this.MTBFlatNum.Size = new System.Drawing.Size(180, 31);
            this.MTBFlatNum.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(420, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 58);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maintenance Amount(₹)\r\n(Per Month)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(420, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delete Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(420, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area (SqFt)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Floor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Block";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flat No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlDGV
            // 
            this.PnlDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDGV.BackColor = System.Drawing.SystemColors.Desktop;
            this.PnlDGV.Controls.Add(this.LbTRC);
            this.PnlDGV.Controls.Add(this.label7);
            this.PnlDGV.Controls.Add(this.DGVFlats);
            this.PnlDGV.Location = new System.Drawing.Point(14, 265);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Padding = new System.Windows.Forms.Padding(2);
            this.PnlDGV.Size = new System.Drawing.Size(950, 336);
            this.PnlDGV.TabIndex = 1;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbTRC.Location = new System.Drawing.Point(107, 305);
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
            this.label7.Location = new System.Drawing.Point(6, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Rows: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVFlats
            // 
            this.DGVFlats.AllowUserToAddRows = false;
            this.DGVFlats.AllowUserToDeleteRows = false;
            this.DGVFlats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVFlats.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVFlats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFlats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVFlats.ColumnHeadersHeight = 34;
            this.DGVFlats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVFlats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVFlats.EnableHeadersVisualStyles = false;
            this.DGVFlats.Location = new System.Drawing.Point(3, 5);
            this.DGVFlats.Name = "DGVFlats";
            this.DGVFlats.ReadOnly = true;
            this.DGVFlats.RowHeadersWidth = 40;
            this.DGVFlats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVFlats.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVFlats.RowTemplate.Height = 28;
            this.DGVFlats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFlats.Size = new System.Drawing.Size(945, 290);
            this.DGVFlats.TabIndex = 0;
            this.DGVFlats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFlats_CellClick);
            // 
            // FormFlats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.GrpBxFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFlats";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Flats";
            this.Load += new System.EventHandler(this.FormFlats_Load);
            this.GrpBxFlats.ResumeLayout(false);
            this.GrpBxFlats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMntAmnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSqFt)).EndInit();
            this.PnlDGV.ResumeLayout(false);
            this.PnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBxFlats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlDGV;
        private System.Windows.Forms.MaskedTextBox MTBFlatNum;
        private System.Windows.Forms.NumericUpDown NUDMntAmnt;
        private System.Windows.Forms.NumericUpDown NUDSqFt;
        private System.Windows.Forms.CheckBox ChkBxDelSts;
        private System.Windows.Forms.ComboBox CmbBxFloor;
        private System.Windows.Forms.ComboBox CmbBxBlock;
        private System.Windows.Forms.DataGridView DGVFlats;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
    }
}