namespace ApartmentMS
{
    partial class FormExpenses
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
            this.DGVExpenses = new System.Windows.Forms.DataGridView();
            this.GrpBxFlats = new System.Windows.Forms.GroupBox();
            this.DTPExpDate = new System.Windows.Forms.DateTimePicker();
            this.TxtBxExpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NUDExpAmnt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpenses)).BeginInit();
            this.GrpBxFlats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDExpAmnt)).BeginInit();
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
            this.PnlDGV.Controls.Add(this.DGVExpenses);
            this.PnlDGV.Location = new System.Drawing.Point(17, 265);
            this.PnlDGV.Name = "PnlDGV";
            this.PnlDGV.Size = new System.Drawing.Size(945, 336);
            this.PnlDGV.TabIndex = 5;
            // 
            // LbTRC
            // 
            this.LbTRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTRC.AutoSize = true;
            this.LbTRC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbTRC.Location = new System.Drawing.Point(102, 305);
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
            this.label7.Location = new System.Drawing.Point(4, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Rows: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVExpenses
            // 
            this.DGVExpenses.AllowUserToAddRows = false;
            this.DGVExpenses.AllowUserToDeleteRows = false;
            this.DGVExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVExpenses.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVExpenses.ColumnHeadersHeight = 34;
            this.DGVExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVExpenses.EnableHeadersVisualStyles = false;
            this.DGVExpenses.Location = new System.Drawing.Point(2, 5);
            this.DGVExpenses.Name = "DGVExpenses";
            this.DGVExpenses.ReadOnly = true;
            this.DGVExpenses.RowHeadersWidth = 40;
            this.DGVExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVExpenses.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVExpenses.RowTemplate.Height = 28;
            this.DGVExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExpenses.Size = new System.Drawing.Size(940, 290);
            this.DGVExpenses.TabIndex = 0;
            this.DGVExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVExpenses_CellClick);
            // 
            // GrpBxFlats
            // 
            this.GrpBxFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxFlats.BackColor = System.Drawing.SystemColors.Desktop;
            this.GrpBxFlats.Controls.Add(this.DTPExpDate);
            this.GrpBxFlats.Controls.Add(this.TxtBxExpName);
            this.GrpBxFlats.Controls.Add(this.label5);
            this.GrpBxFlats.Controls.Add(this.BtnReset);
            this.GrpBxFlats.Controls.Add(this.BtnRemove);
            this.GrpBxFlats.Controls.Add(this.BtnEdit);
            this.GrpBxFlats.Controls.Add(this.BtnAdd);
            this.GrpBxFlats.Controls.Add(this.NUDExpAmnt);
            this.GrpBxFlats.Controls.Add(this.label6);
            this.GrpBxFlats.Controls.Add(this.label4);
            this.GrpBxFlats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpBxFlats.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxFlats.ForeColor = System.Drawing.Color.Linen;
            this.GrpBxFlats.Location = new System.Drawing.Point(17, 9);
            this.GrpBxFlats.Name = "GrpBxFlats";
            this.GrpBxFlats.Size = new System.Drawing.Size(945, 250);
            this.GrpBxFlats.TabIndex = 4;
            this.GrpBxFlats.TabStop = false;
            this.GrpBxFlats.Text = "Expenses";
            // 
            // DTPExpDate
            // 
            this.DTPExpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPExpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPExpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPExpDate.Location = new System.Drawing.Point(239, 157);
            this.DTPExpDate.Name = "DTPExpDate";
            this.DTPExpDate.Size = new System.Drawing.Size(220, 31);
            this.DTPExpDate.TabIndex = 19;
            // 
            // TxtBxExpName
            // 
            this.TxtBxExpName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtBxExpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxExpName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxExpName.Location = new System.Drawing.Point(239, 63);
            this.TxtBxExpName.Name = "TxtBxExpName";
            this.TxtBxExpName.Size = new System.Drawing.Size(300, 31);
            this.TxtBxExpName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(20, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Exp Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnReset.Location = new System.Drawing.Point(761, 145);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(120, 39);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRemove.AutoSize = true;
            this.BtnRemove.BackColor = System.Drawing.Color.Bisque;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnRemove.Location = new System.Drawing.Point(610, 145);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 39);
            this.BtnRemove.TabIndex = 14;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.BackColor = System.Drawing.Color.Bisque;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEdit.Location = new System.Drawing.Point(761, 89);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(120, 39);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAdd.Location = new System.Drawing.Point(610, 89);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 39);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NUDExpAmnt
            // 
            this.NUDExpAmnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NUDExpAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDExpAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDExpAmnt.Location = new System.Drawing.Point(239, 108);
            this.NUDExpAmnt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDExpAmnt.Name = "NUDExpAmnt";
            this.NUDExpAmnt.Size = new System.Drawing.Size(220, 34);
            this.NUDExpAmnt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Expense Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expense Amount(₹)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.PnlDGV);
            this.Controls.Add(this.GrpBxFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExpenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.FormExpenses_Load);
            this.PnlDGV.ResumeLayout(false);
            this.PnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExpenses)).EndInit();
            this.GrpBxFlats.ResumeLayout(false);
            this.GrpBxFlats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDExpAmnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDGV;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVExpenses;
        private System.Windows.Forms.GroupBox GrpBxFlats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NUDExpAmnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBxExpName;
        private System.Windows.Forms.DateTimePicker DTPExpDate;
    }
}