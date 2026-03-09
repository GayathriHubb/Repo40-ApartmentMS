namespace ApartmentMS
{
    partial class FormResidents
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
            this.DGVResidents = new System.Windows.Forms.DataGridView();
            this.GrpBxFlats = new System.Windows.Forms.GroupBox();
            this.CmbBxFlatInfo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DTPMoveIn = new System.Windows.Forms.DateTimePicker();
            this.TxtBxResdName = new System.Windows.Forms.TextBox();
            this.ChkBxActvSts = new System.Windows.Forms.CheckBox();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResidents)).BeginInit();
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
            this.PnlDGV.Controls.Add(this.DGVResidents);
            this.PnlDGV.Location = new System.Drawing.Point(14, 265);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Size = new System.Drawing.Size(950, 336);
            this.PnlDGV.TabIndex = 3;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbTRC.Location = new System.Drawing.Point(106, 304);
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
            this.label7.Location = new System.Drawing.Point(5, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Rows: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVResidents
            // 
            this.DGVResidents.AllowUserToAddRows = false;
            this.DGVResidents.AllowUserToDeleteRows = false;
            this.DGVResidents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVResidents.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVResidents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVResidents.ColumnHeadersHeight = 34;
            this.DGVResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVResidents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVResidents.EnableHeadersVisualStyles = false;
            this.DGVResidents.Location = new System.Drawing.Point(3, 5);
            this.DGVResidents.Name = "DGVResidents";
            this.DGVResidents.ReadOnly = true;
            this.DGVResidents.RowHeadersWidth = 40;
            this.DGVResidents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVResidents.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVResidents.RowTemplate.Height = 28;
            this.DGVResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVResidents.Size = new System.Drawing.Size(945, 285);
            this.DGVResidents.TabIndex = 0;
            this.DGVResidents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVResidents_CellClick);
            // 
            // GrpBxFlats
            // 
            this.GrpBxFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxFlats.BackColor = System.Drawing.SystemColors.Desktop;
            this.GrpBxFlats.Controls.Add(this.CmbBxFlatInfo);
            this.GrpBxFlats.Controls.Add(this.label4);
            this.GrpBxFlats.Controls.Add(this.BtnReset);
            this.GrpBxFlats.Controls.Add(this.BtnRemove);
            this.GrpBxFlats.Controls.Add(this.BtnEdit);
            this.GrpBxFlats.Controls.Add(this.BtnAdd);
            this.GrpBxFlats.Controls.Add(this.DTPMoveIn);
            this.GrpBxFlats.Controls.Add(this.TxtBxResdName);
            this.GrpBxFlats.Controls.Add(this.ChkBxActvSts);
            this.GrpBxFlats.Controls.Add(this.MTBPhnNum);
            this.GrpBxFlats.Controls.Add(this.label5);
            this.GrpBxFlats.Controls.Add(this.label3);
            this.GrpBxFlats.Controls.Add(this.label2);
            this.GrpBxFlats.Controls.Add(this.label1);
            this.GrpBxFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBxFlats.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxFlats.ForeColor = System.Drawing.Color.Linen;
            this.GrpBxFlats.Location = new System.Drawing.Point(14, 9);
            this.GrpBxFlats.Name = "GrpBxFlats";
            this.GrpBxFlats.Size = new System.Drawing.Size(950, 250);
            this.GrpBxFlats.TabIndex = 2;
            this.GrpBxFlats.TabStop = false;
            this.GrpBxFlats.Text = "Residents";
            // 
            // CmbBxFlatInfo
            // 
            this.CmbBxFlatInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbBxFlatInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBxFlatInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxFlatInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxFlatInfo.FormattingEnabled = true;
            this.CmbBxFlatInfo.Location = new System.Drawing.Point(170, 40);
            this.CmbBxFlatInfo.Name = "CmbBxFlatInfo";
            this.CmbBxFlatInfo.Size = new System.Drawing.Size(180, 33);
            this.CmbBxFlatInfo.TabIndex = 21;
            this.CmbBxFlatInfo.SelectedIndexChanged += new System.EventHandler(this.CmbBxFlatNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(27, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Flat No.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnReset.Location = new System.Drawing.Point(655, 195);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 39);
            this.BtnReset.TabIndex = 19;
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
            this.BtnRemove.Location = new System.Drawing.Point(495, 195);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 39);
            this.BtnRemove.TabIndex = 18;
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
            this.BtnEdit.Location = new System.Drawing.Point(335, 195);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 39);
            this.BtnEdit.TabIndex = 17;
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
            this.BtnAdd.Location = new System.Drawing.Point(175, 195);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 39);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DTPMoveIn
            // 
            this.DTPMoveIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DTPMoveIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPMoveIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPMoveIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPMoveIn.Location = new System.Drawing.Point(651, 41);
            this.DTPMoveIn.Name = "DTPMoveIn";
            this.DTPMoveIn.Size = new System.Drawing.Size(220, 31);
            this.DTPMoveIn.TabIndex = 13;
            // 
            // TxtBxResdName
            // 
            this.TxtBxResdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxResdName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxResdName.Location = new System.Drawing.Point(166, 90);
            this.TxtBxResdName.Name = "TxtBxResdName";
            this.TxtBxResdName.Size = new System.Drawing.Size(300, 31);
            this.TxtBxResdName.TabIndex = 12;
            // 
            // ChkBxActvSts
            // 
            this.ChkBxActvSts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChkBxActvSts.AutoSize = true;
            this.ChkBxActvSts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkBxActvSts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxActvSts.Location = new System.Drawing.Point(651, 95);
            this.ChkBxActvSts.Name = "ChkBxActvSts";
            this.ChkBxActvSts.Size = new System.Drawing.Size(22, 21);
            this.ChkBxActvSts.TabIndex = 9;
            this.ChkBxActvSts.UseVisualStyleBackColor = true;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(166, 141);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(180, 31);
            this.MTBPhnNum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(498, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Active Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(498, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "MoveIn Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phn No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resd Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.GrpBxFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResidents";
            this.Text = "Residents";
            this.Load += new System.EventHandler(this.FormResidents_Load);
            this.PnlDGV.ResumeLayout(false);
            this.PnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResidents)).EndInit();
            this.GrpBxFlats.ResumeLayout(false);
            this.GrpBxFlats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDGV;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVResidents;
        private System.Windows.Forms.GroupBox GrpBxFlats;
        private System.Windows.Forms.CheckBox ChkBxActvSts;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBxResdName;
        private System.Windows.Forms.DateTimePicker DTPMoveIn;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbBxFlatInfo;
        private System.Windows.Forms.Label label4;
    }
}