namespace denemeGrafik
{
    partial class grafikForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.cbLast = new System.Windows.Forms.ComboBox();
            this.colGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oğrenci No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(20, 41);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(270, 22);
            this.txtNo.TabIndex = 0;
            // 
            // cbLast
            // 
            this.cbLast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLast.FormattingEnabled = true;
            this.cbLast.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbLast.Location = new System.Drawing.Point(20, 150);
            this.cbLast.Name = "cbLast";
            this.cbLast.Size = new System.Drawing.Size(270, 24);
            this.cbLast.TabIndex = 5;
            // 
            // colGraph
            // 
            this.colGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.IsMarksNextToAxis = false;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsMarksNextToAxis = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.IsMarksNextToAxis = false;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.DimGray;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.colGraph.ChartAreas.Add(chartArea1);
            this.colGraph.Location = new System.Drawing.Point(354, 31);
            this.colGraph.Name = "colGraph";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            series1.Name = "Series1";
            this.colGraph.Series.Add(series1);
            this.colGraph.Size = new System.Drawing.Size(781, 314);
            this.colGraph.TabIndex = 6;
            this.colGraph.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label4.Location = new System.Drawing.Point(9, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Varol Yılmaz PARLAK";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(187, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Grafiğe Dök";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label5.Location = new System.Drawing.Point(652, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bilgileri Giriniz";
            // 
            // lineGraph
            // 
            this.lineGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsMarksNextToAxis = false;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.IsMarksNextToAxis = false;
            chartArea2.AxisX2.LineWidth = 0;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.IsMarksNextToAxis = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.IsMarksNextToAxis = false;
            chartArea2.AxisY2.LabelStyle.Enabled = false;
            chartArea2.AxisY2.LineWidth = 0;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.DimGray;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.lineGraph.ChartAreas.Add(chartArea2);
            this.lineGraph.Location = new System.Drawing.Point(354, 333);
            this.lineGraph.Name = "lineGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            series2.Name = "Series1";
            this.lineGraph.Series.Add(series2);
            this.lineGraph.Size = new System.Drawing.Size(759, 324);
            this.lineGraph.TabIndex = 11;
            this.lineGraph.Text = "chart1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.linkLabel1.Location = new System.Drawing.Point(18, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 36);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bu Öğrenciye Ait \r\nBütün Verileri Göster";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbDers
            // 
            this.cbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Items.AddRange(new object[] {
            "Matematik",
            "Fen Bilgisi",
            "Sosyal Bilgiler",
            "İngilizce",
            "Din Kültürü",
            "Türkçe",
            "Geometri",
            "Tarih",
            "Coğrafya",
            "Felsefe",
            "Fizik",
            "Kimya",
            "Biyoloji"});
            this.cbDers.Location = new System.Drawing.Point(21, 95);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(270, 24);
            this.cbDers.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(560, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "Soruların Sayısı Altta,\r\nYanlış Cevapların Sayısı Yüzde Şeklinde Yukarı Yazılmışt" +
    "ır!\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Visible = false;
            // 
            // grafikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1147, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lineGraph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colGraph);
            this.Controls.Add(this.cbLast);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "grafikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik Ekranı";
            this.Load += new System.EventHandler(this.grafikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.ComboBox cbLast;
        private System.Windows.Forms.DataVisualization.Charting.Chart colGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineGraph;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Label label6;
    }
}