namespace OnlyIphone
{
    partial class main
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dayNumerLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayNameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.totalcountLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.salesNumberLabel = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.clientsNumberLabel = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.ordersNumberLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsNumberLabel = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.clientsPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.salesPanel = new System.Windows.Forms.Panel();
            this.datePanel = new System.Windows.Forms.Panel();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.salesPanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dayNumerLabel
            // 
            this.dayNumerLabel.AutoSize = true;
            this.dayNumerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dayNumerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNumerLabel.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dayNumerLabel.Location = new System.Drawing.Point(7, 0);
            this.dayNumerLabel.Name = "dayNumerLabel";
            this.dayNumerLabel.Size = new System.Drawing.Size(186, 116);
            this.dayNumerLabel.TabIndex = 22;
            this.dayNumerLabel.Text = "31";
            this.dayNumerLabel.Click += new System.EventHandler(this.dayNumerLabel_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.monthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.monthLabel.Location = new System.Drawing.Point(166, 49);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(95, 23);
            this.monthLabel.TabIndex = 27;
            this.monthLabel.Text = "Octubre";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.yearLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.yearLabel.Location = new System.Drawing.Point(167, 77);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(66, 23);
            this.yearLabel.TabIndex = 26;
            this.yearLabel.Text = "2017";
            this.yearLabel.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // dayNameLabel
            // 
            this.dayNameLabel.AutoSize = true;
            this.dayNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dayNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dayNameLabel.Location = new System.Drawing.Point(167, 22);
            this.dayNameLabel.Name = "dayNameLabel";
            this.dayNameLabel.Size = new System.Drawing.Size(83, 23);
            this.dayNameLabel.TabIndex = 25;
            this.dayNameLabel.Text = "Martes";
            this.dayNameLabel.Click += new System.EventHandler(this.dayNameLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.timeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.timeLabel.Location = new System.Drawing.Point(296, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 78);
            this.timeLabel.TabIndex = 28;
            // 
            // totalcountLabel
            // 
            this.totalcountLabel.AutoSize = true;
            this.totalcountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.totalcountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalcountLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalcountLabel.Location = new System.Drawing.Point(248, 18);
            this.totalcountLabel.Name = "totalcountLabel";
            this.totalcountLabel.Size = new System.Drawing.Size(147, 78);
            this.totalcountLabel.TabIndex = 32;
            this.totalcountLabel.Text = "$ 0";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.salesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.salesLabel.Location = new System.Drawing.Point(30, 78);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(105, 29);
            this.salesLabel.TabIndex = 31;
            this.salesLabel.Text = "Ventas";
            // 
            // salesNumberLabel
            // 
            this.salesNumberLabel.AutoSize = true;
            this.salesNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.salesNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesNumberLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.salesNumberLabel.Location = new System.Drawing.Point(22, 8);
            this.salesNumberLabel.Name = "salesNumberLabel";
            this.salesNumberLabel.Size = new System.Drawing.Size(79, 78);
            this.salesNumberLabel.TabIndex = 30;
            this.salesNumberLabel.Text = "0";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.clientsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientsLabel.Location = new System.Drawing.Point(23, 58);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(77, 18);
            this.clientsLabel.TabIndex = 42;
            this.clientsLabel.Text = "Clientes";
            this.clientsLabel.Click += new System.EventHandler(this.clientsLabel_Click);
            // 
            // clientsNumberLabel
            // 
            this.clientsNumberLabel.AutoSize = true;
            this.clientsNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.clientsNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientsNumberLabel.Location = new System.Drawing.Point(20, 9);
            this.clientsNumberLabel.Name = "clientsNumberLabel";
            this.clientsNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.clientsNumberLabel.TabIndex = 41;
            this.clientsNumberLabel.Text = "0";
            this.clientsNumberLabel.Click += new System.EventHandler(this.clientsNumberLabel_Click);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ordersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ordersLabel.Location = new System.Drawing.Point(13, 57);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(83, 18);
            this.ordersLabel.TabIndex = 39;
            this.ordersLabel.Text = "Ordenes";
            this.ordersLabel.Click += new System.EventHandler(this.ordersLabel_Click);
            // 
            // ordersNumberLabel
            // 
            this.ordersNumberLabel.AutoSize = true;
            this.ordersNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ordersNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ordersNumberLabel.Location = new System.Drawing.Point(9, 9);
            this.ordersNumberLabel.Name = "ordersNumberLabel";
            this.ordersNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.ordersNumberLabel.TabIndex = 38;
            this.ordersNumberLabel.Text = "0";
            this.ordersNumberLabel.Click += new System.EventHandler(this.ordersNumberLabel_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.productsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productsLabel.Location = new System.Drawing.Point(13, 56);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(97, 18);
            this.productsLabel.TabIndex = 36;
            this.productsLabel.Text = "Productos";
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click);
            // 
            // productsNumberLabel
            // 
            this.productsNumberLabel.AutoSize = true;
            this.productsNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.productsNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsNumberLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productsNumberLabel.Location = new System.Drawing.Point(10, 7);
            this.productsNumberLabel.Name = "productsNumberLabel";
            this.productsNumberLabel.Size = new System.Drawing.Size(43, 42);
            this.productsNumberLabel.TabIndex = 35;
            this.productsNumberLabel.Text = "0";
            this.productsNumberLabel.Click += new System.EventHandler(this.productsNumberLabel_Click);
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.productsPanel.Controls.Add(this.panel4);
            this.productsPanel.Controls.Add(this.pictureBox4);
            this.productsPanel.Controls.Add(this.productsNumberLabel);
            this.productsPanel.Controls.Add(this.productsLabel);
            this.productsPanel.Location = new System.Drawing.Point(37, 347);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(215, 95);
            this.productsPanel.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 19);
            this.panel4.TabIndex = 38;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.pictureBox4.Image = global::OnlyIphone.Properties.Resources.box_41;
            this.pictureBox4.Location = new System.Drawing.Point(115, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // clientsPanel
            // 
            this.clientsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.clientsPanel.Controls.Add(this.panel5);
            this.clientsPanel.Controls.Add(this.clientsLabel);
            this.clientsPanel.Controls.Add(this.clientsNumberLabel);
            this.clientsPanel.Controls.Add(this.pictureBox3);
            this.clientsPanel.Location = new System.Drawing.Point(324, 347);
            this.clientsPanel.Name = "clientsPanel";
            this.clientsPanel.Size = new System.Drawing.Size(215, 95);
            this.clientsPanel.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(133)))), ((int)(((byte)(15)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 19);
            this.panel5.TabIndex = 43;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.pictureBox3.Image = global::OnlyIphone.Properties.Resources.users_social_symbol;
            this.pictureBox3.Location = new System.Drawing.Point(115, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.ordersPanel.Controls.Add(this.panel6);
            this.ordersPanel.Controls.Add(this.pictureBox6);
            this.ordersPanel.Controls.Add(this.ordersLabel);
            this.ordersPanel.Controls.Add(this.ordersNumberLabel);
            this.ordersPanel.Location = new System.Drawing.Point(613, 347);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(215, 95);
            this.ordersPanel.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(64)))), ((int)(((byte)(49)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 19);
            this.panel6.TabIndex = 44;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(115, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // salesPanel
            // 
            this.salesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.salesPanel.Controls.Add(this.totalcountLabel);
            this.salesPanel.Controls.Add(this.salesNumberLabel);
            this.salesPanel.Controls.Add(this.salesLabel);
            this.salesPanel.Location = new System.Drawing.Point(37, 200);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(791, 116);
            this.salesPanel.TabIndex = 46;
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.datePanel.Controls.Add(this.dayNameLabel);
            this.datePanel.Controls.Add(this.yearLabel);
            this.datePanel.Controls.Add(this.monthLabel);
            this.datePanel.Controls.Add(this.dayNumerLabel);
            this.datePanel.Controls.Add(this.timeLabel);
            this.datePanel.Location = new System.Drawing.Point(37, 47);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(791, 116);
            this.datePanel.TabIndex = 47;
            this.datePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.salesPanel);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.clientsPanel);
            this.Controls.Add(this.productsPanel);
            this.Name = "main";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.clientsPanel.ResumeLayout(false);
            this.clientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.salesPanel.ResumeLayout(false);
            this.salesPanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dayNumerLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label totalcountLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label salesNumberLabel;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.Label clientsNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label ordersNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label productsNumberLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel clientsPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Panel datePanel;
    }
}
