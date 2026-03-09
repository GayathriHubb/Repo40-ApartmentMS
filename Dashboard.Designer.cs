namespace ApartmentMS
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTD = new System.Windows.Forms.Panel();
            this.LbNetBal = new System.Windows.Forms.Label();
            this.LbNetBalance = new System.Windows.Forms.Label();
            this.PnlTC = new System.Windows.Forms.Panel();
            this.LbPndMntCnt = new System.Windows.Forms.Label();
            this.LbPndMnt = new System.Windows.Forms.Label();
            this.PnlTB = new System.Windows.Forms.Panel();
            this.LbOcpdFlatsCnt = new System.Windows.Forms.Label();
            this.LbOcpiedFlats = new System.Windows.Forms.Label();
            this.PnlTA = new System.Windows.Forms.Panel();
            this.LbTotFlatsCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TLP1.SuspendLayout();
            this.PnlTD.SuspendLayout();
            this.PnlTC.SuspendLayout();
            this.PnlTB.SuspendLayout();
            this.PnlTA.SuspendLayout();
            this.Pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP1
            // 
            this.TLP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP1.BackColor = System.Drawing.SystemColors.Desktop;
            this.TLP1.ColumnCount = 4;
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP1.Controls.Add(this.PnlTD, 3, 0);
            this.TLP1.Controls.Add(this.PnlTC, 2, 0);
            this.TLP1.Controls.Add(this.PnlTB, 1, 0);
            this.TLP1.Controls.Add(this.PnlTA, 0, 0);
            this.TLP1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TLP1.Location = new System.Drawing.Point(14, 5);
            this.TLP1.Name = "TLP1";
            this.TLP1.RowCount = 1;
            this.TLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TLP1.Size = new System.Drawing.Size(950, 150);
            this.TLP1.TabIndex = 0;
            // 
            // PnlTD
            // 
            this.PnlTD.Controls.Add(this.LbNetBal);
            this.PnlTD.Controls.Add(this.LbNetBalance);
            this.PnlTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTD.Location = new System.Drawing.Point(714, 3);
            this.PnlTD.Name = "PnlTD";
            this.PnlTD.Size = new System.Drawing.Size(233, 144);
            this.PnlTD.TabIndex = 9;
            // 
            // LbNetBal
            // 
            this.LbNetBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbNetBal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LbNetBal.ForeColor = System.Drawing.Color.PowderBlue;
            this.LbNetBal.Location = new System.Drawing.Point(16, 70);
            this.LbNetBal.Name = "LbNetBal";
            this.LbNetBal.Size = new System.Drawing.Size(200, 45);
            this.LbNetBal.TabIndex = 4;
            this.LbNetBal.Text = "0";
            this.LbNetBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbNetBalance
            // 
            this.LbNetBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNetBalance.BackColor = System.Drawing.Color.Linen;
            this.LbNetBalance.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNetBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbNetBalance.Location = new System.Drawing.Point(6, 5);
            this.LbNetBalance.Name = "LbNetBalance";
            this.LbNetBalance.Size = new System.Drawing.Size(221, 35);
            this.LbNetBalance.TabIndex = 35;
            this.LbNetBalance.Text = "Net Balance(₹)";
            this.LbNetBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTC
            // 
            this.PnlTC.Controls.Add(this.LbPndMntCnt);
            this.PnlTC.Controls.Add(this.LbPndMnt);
            this.PnlTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTC.Location = new System.Drawing.Point(477, 3);
            this.PnlTC.Name = "PnlTC";
            this.PnlTC.Size = new System.Drawing.Size(231, 144);
            this.PnlTC.TabIndex = 4;
            // 
            // LbPndMntCnt
            // 
            this.LbPndMntCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbPndMntCnt.AutoSize = true;
            this.LbPndMntCnt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPndMntCnt.ForeColor = System.Drawing.Color.PowderBlue;
            this.LbPndMntCnt.Location = new System.Drawing.Point(96, 68);
            this.LbPndMntCnt.Name = "LbPndMntCnt";
            this.LbPndMntCnt.Size = new System.Drawing.Size(38, 45);
            this.LbPndMntCnt.TabIndex = 33;
            this.LbPndMntCnt.Text = "0";
            this.LbPndMntCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPndMnt
            // 
            this.LbPndMnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPndMnt.BackColor = System.Drawing.Color.Linen;
            this.LbPndMnt.Font = new System.Drawing.Font("Prata", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPndMnt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbPndMnt.Location = new System.Drawing.Point(6, 5);
            this.LbPndMnt.Name = "LbPndMnt";
            this.LbPndMnt.Size = new System.Drawing.Size(219, 35);
            this.LbPndMnt.TabIndex = 32;
            this.LbPndMnt.Text = "Pending Maintenance Count";
            this.LbPndMnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTB
            // 
            this.PnlTB.Controls.Add(this.LbOcpdFlatsCnt);
            this.PnlTB.Controls.Add(this.LbOcpiedFlats);
            this.PnlTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTB.Location = new System.Drawing.Point(240, 3);
            this.PnlTB.Name = "PnlTB";
            this.PnlTB.Size = new System.Drawing.Size(231, 144);
            this.PnlTB.TabIndex = 3;
            // 
            // LbOcpdFlatsCnt
            // 
            this.LbOcpdFlatsCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbOcpdFlatsCnt.AutoSize = true;
            this.LbOcpdFlatsCnt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOcpdFlatsCnt.ForeColor = System.Drawing.Color.PowderBlue;
            this.LbOcpdFlatsCnt.Location = new System.Drawing.Point(96, 68);
            this.LbOcpdFlatsCnt.Name = "LbOcpdFlatsCnt";
            this.LbOcpdFlatsCnt.Size = new System.Drawing.Size(38, 45);
            this.LbOcpdFlatsCnt.TabIndex = 2;
            this.LbOcpdFlatsCnt.Text = "0";
            this.LbOcpdFlatsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbOcpiedFlats
            // 
            this.LbOcpiedFlats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbOcpiedFlats.BackColor = System.Drawing.Color.Linen;
            this.LbOcpiedFlats.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOcpiedFlats.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LbOcpiedFlats.Location = new System.Drawing.Point(5, 5);
            this.LbOcpiedFlats.Name = "LbOcpiedFlats";
            this.LbOcpiedFlats.Size = new System.Drawing.Size(221, 35);
            this.LbOcpiedFlats.TabIndex = 31;
            this.LbOcpiedFlats.Text = "Occupied Flats";
            this.LbOcpiedFlats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlTA
            // 
            this.PnlTA.Controls.Add(this.LbTotFlatsCnt);
            this.PnlTA.Controls.Add(this.label2);
            this.PnlTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTA.Location = new System.Drawing.Point(3, 3);
            this.PnlTA.Name = "PnlTA";
            this.PnlTA.Size = new System.Drawing.Size(231, 144);
            this.PnlTA.TabIndex = 2;
            // 
            // LbTotFlatsCnt
            // 
            this.LbTotFlatsCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbTotFlatsCnt.AutoSize = true;
            this.LbTotFlatsCnt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotFlatsCnt.ForeColor = System.Drawing.Color.PowderBlue;
            this.LbTotFlatsCnt.Location = new System.Drawing.Point(96, 68);
            this.LbTotFlatsCnt.Name = "LbTotFlatsCnt";
            this.LbTotFlatsCnt.Size = new System.Drawing.Size(38, 45);
            this.LbTotFlatsCnt.TabIndex = 1;
            this.LbTotFlatsCnt.Text = "0";
            this.LbTotFlatsCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 35);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Flats";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl1
            // 
            this.Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Pnl1.Controls.Add(this.Chart1);
            this.Pnl1.Location = new System.Drawing.Point(14, 175);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(950, 400);
            this.Pnl1.TabIndex = 1;
            // 
            // Chart1
            // 
            this.Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Bisque;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(137, 25);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Font = new System.Drawing.Font("Prata", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "IncExp";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(650, 350);
            this.Chart1.TabIndex = 0;
            title1.BackColor = System.Drawing.Color.Linen;
            title1.Font = new System.Drawing.Font("Prata", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Income Vs Expense";
            this.Chart1.Titles.Add(title1);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.TLP1);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.TLP1.ResumeLayout(false);
            this.PnlTD.ResumeLayout(false);
            this.PnlTC.ResumeLayout(false);
            this.PnlTC.PerformLayout();
            this.PnlTB.ResumeLayout(false);
            this.PnlTB.PerformLayout();
            this.PnlTA.ResumeLayout(false);
            this.PnlTA.PerformLayout();
            this.Pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP1;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel PnlTC;
        private System.Windows.Forms.Panel PnlTB;
        private System.Windows.Forms.Label LbOcpiedFlats;
        private System.Windows.Forms.Panel PnlTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbPndMnt;
        private System.Windows.Forms.Label LbTotFlatsCnt;
        private System.Windows.Forms.Label LbPndMntCnt;
        private System.Windows.Forms.Label LbOcpdFlatsCnt;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Panel PnlTD;
        private System.Windows.Forms.Label LbNetBal;
        private System.Windows.Forms.Label LbNetBalance;
    }
}