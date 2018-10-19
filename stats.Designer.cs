namespace OnlyIphone
{
    partial class stats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sales_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_title_cashbox = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load_data_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdf_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales_chart
            // 
            this.sales_chart.BorderlineColor = System.Drawing.Color.Transparent;
            this.sales_chart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.sales_chart.BorderSkin.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.sales_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sales_chart.Legends.Add(legend1);
            this.sales_chart.Location = new System.Drawing.Point(24, 116);
            this.sales_chart.Margin = new System.Windows.Forms.Padding(2);
            this.sales_chart.Name = "sales_chart";
            this.sales_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelToolTip = "#VAL{C0}";
            series1.Legend = "Legend1";
            series1.LegendText = "Ventas";
            series1.Name = "Ventas";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ShadowColor = System.Drawing.Color.DarkGray;
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.MaxMovingDistance = 1D;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.sales_chart.Series.Add(series1);
            this.sales_chart.Size = new System.Drawing.Size(815, 313);
            this.sales_chart.TabIndex = 0;
            this.sales_chart.Text = "Ventas";
            this.sales_chart.Click += new System.EventHandler(this.chart1_Click);
            this.sales_chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sales_chart_MouseMove);
            // 
            // label_title_cashbox
            // 
            this.label_title_cashbox.AutoSize = true;
            this.label_title_cashbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_cashbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_cashbox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_cashbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_cashbox.Location = new System.Drawing.Point(37, 30);
            this.label_title_cashbox.Name = "label_title_cashbox";
            this.label_title_cashbox.Size = new System.Drawing.Size(151, 25);
            this.label_title_cashbox.TabIndex = 40;
            this.label_title_cashbox.Text = "Estadísticas";
            this.label_title_cashbox.Click += new System.EventHandler(this.label_title_cashbox_Click);
            // 
            // date1
            // 
            this.date1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.date1.CalendarMonthBackground = System.Drawing.Color.White;
            this.date1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.date1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.date1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(187)))), ((int)(((byte)(200)))));
            this.date1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Location = new System.Drawing.Point(78, 70);
            this.date1.Margin = new System.Windows.Forms.Padding(2);
            this.date1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 20);
            this.date1.TabIndex = 45;
            // 
            // date2
            // 
            this.date2.CalendarFont = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.date2.CalendarMonthBackground = System.Drawing.Color.White;
            this.date2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.date2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.date2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(187)))), ((int)(((byte)(200)))));
            this.date2.Location = new System.Drawing.Point(315, 70);
            this.date2.Margin = new System.Windows.Forms.Padding(2);
            this.date2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(151, 20);
            this.date2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(263, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Hasta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // load_data_button
            // 
            this.load_data_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.load_data_button.FlatAppearance.BorderSize = 0;
            this.load_data_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_data_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_data_button.ForeColor = System.Drawing.Color.White;
            this.load_data_button.Location = new System.Drawing.Point(519, 69);
            this.load_data_button.Margin = new System.Windows.Forms.Padding(2);
            this.load_data_button.Name = "load_data_button";
            this.load_data_button.Size = new System.Drawing.Size(86, 20);
            this.load_data_button.TabIndex = 50;
            this.load_data_button.Text = "Consultar";
            this.load_data_button.UseVisualStyleBackColor = false;
            this.load_data_button.Click += new System.EventHandler(this.load_data_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(21, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total del Periodo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(172, 458);
            this.total_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(0, 17);
            this.total_label.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.load_data_button);
            this.panel1.Controls.Add(this.label_title_cashbox);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 103);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pdf_button
            // 
            this.pdf_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.pdf_button.FlatAppearance.BorderSize = 0;
            this.pdf_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdf_button.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf_button.ForeColor = System.Drawing.Color.White;
            this.pdf_button.Image = global::OnlyIphone.Properties.Resources.foundation_icon_fonts_2015_02_16_page_export_pdf_20_0_f1f1f1_none;
            this.pdf_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pdf_button.Location = new System.Drawing.Point(685, 444);
            this.pdf_button.Margin = new System.Windows.Forms.Padding(2);
            this.pdf_button.Name = "pdf_button";
            this.pdf_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pdf_button.Size = new System.Drawing.Size(154, 44);
            this.pdf_button.TabIndex = 54;
            this.pdf_button.Text = "   Exportar a PDF";
            this.pdf_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pdf_button.UseVisualStyleBackColor = false;
            this.pdf_button.Click += new System.EventHandler(this.pdf_button_Click);
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pdf_button);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sales_chart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "stats";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.stats_Load);
            this.Resize += new System.EventHandler(this.stats_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sales_chart;
        private System.Windows.Forms.Label label_title_cashbox;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load_data_button;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pdf_button;
    }
}
