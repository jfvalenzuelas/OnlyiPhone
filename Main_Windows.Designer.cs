namespace OnlyIphone
{
    partial class Main_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Windows));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuPanelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox_config = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.status_dot = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.stats_button = new System.Windows.Forms.Button();
            this.cashboxButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.providersButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.btn_minimize_sidemenu = new System.Windows.Forms.Button();
            this.box_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.box_minimize = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.menuPanelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuPanel.Controls.Add(this.pictureBox_config);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Controls.Add(this.mainButton);
            this.menuPanel.Controls.Add(this.stats_button);
            this.menuPanel.Controls.Add(this.cashboxButton);
            this.menuPanel.Controls.Add(this.clientsButton);
            this.menuPanel.Controls.Add(this.providersButton);
            this.menuPanel.Controls.Add(this.salesButton);
            this.menuPanel.Controls.Add(this.usersButton);
            this.menuPanel.Controls.Add(this.productsButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 30);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(135, 570);
            this.menuPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "OnlyiPhone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(135, 30);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(865, 570);
            this.containerPanel.TabIndex = 3;
            this.containerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPanel_Paint);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoPanel.Controls.Add(this.userPicture);
            this.logoPanel.Controls.Add(this.panel1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(135, 79);
            this.logoPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(27)))));
            this.headerPanel.Controls.Add(this.btn_minimize_sidemenu);
            this.headerPanel.Controls.Add(this.box_close);
            this.headerPanel.Controls.Add(this.menuPanelLogo);
            this.headerPanel.Controls.Add(this.box_minimize);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 30);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // menuPanelLogo
            // 
            this.menuPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(1)))));
            this.menuPanelLogo.Controls.Add(this.pictureBox1);
            this.menuPanelLogo.Controls.Add(this.label1);
            this.menuPanelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.menuPanelLogo.Name = "menuPanelLogo";
            this.menuPanelLogo.Size = new System.Drawing.Size(135, 30);
            this.menuPanelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Controls.Add(this.status_dot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 26);
            this.panel1.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welcomeLabel.Location = new System.Drawing.Point(35, 6);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(58, 14);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Usuario";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // pictureBox_config
            // 
            this.pictureBox_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.pictureBox_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_config.Image = global::OnlyIphone.Properties.Resources.mfg_labs_iconset_2014_07_29_settings_20_0_f1f1f1_none;
            this.pictureBox_config.Location = new System.Drawing.Point(3, 547);
            this.pictureBox_config.Name = "pictureBox_config";
            this.pictureBox_config.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_config.TabIndex = 2;
            this.pictureBox_config.TabStop = false;
            this.pictureBox_config.Click += new System.EventHandler(this.pictureBox_config_Click);
            // 
            // userPicture
            // 
            this.userPicture.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_user_circle_o_45_0_f1f1f1_none;
            this.userPicture.Location = new System.Drawing.Point(45, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(45, 45);
            this.userPicture.TabIndex = 1;
            this.userPicture.TabStop = false;
            // 
            // status_dot
            // 
            this.status_dot.BackgroundImage = global::OnlyIphone.Properties.Resources.octicons_4_3_0_primitive_dot_10_0_00a65a_none1;
            this.status_dot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.status_dot.Dock = System.Windows.Forms.DockStyle.Left;
            this.status_dot.Location = new System.Drawing.Point(0, 0);
            this.status_dot.Name = "status_dot";
            this.status_dot.Size = new System.Drawing.Size(34, 26);
            this.status_dot.TabIndex = 0;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mainButton.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_home_20_0_f1f1f1_none;
            this.mainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.Location = new System.Drawing.Point(0, 101);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(135, 30);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "   Principal";
            this.mainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // stats_button
            // 
            this.stats_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.stats_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stats_button.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.stats_button.FlatAppearance.BorderSize = 0;
            this.stats_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stats_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_button.ForeColor = System.Drawing.SystemColors.Control;
            this.stats_button.Image = global::OnlyIphone.Properties.Resources.icomoon_free_2014_12_23_stats_bars_20_0_f1f1f1_none;
            this.stats_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stats_button.Location = new System.Drawing.Point(0, 353);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(135, 30);
            this.stats_button.TabIndex = 9;
            this.stats_button.Text = "   Estadísticas";
            this.stats_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stats_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stats_button.UseVisualStyleBackColor = false;
            this.stats_button.Click += new System.EventHandler(this.stats_button_Click);
            // 
            // cashboxButton
            // 
            this.cashboxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.cashboxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashboxButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.cashboxButton.FlatAppearance.BorderSize = 0;
            this.cashboxButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cashboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashboxButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashboxButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cashboxButton.Image = global::OnlyIphone.Properties.Resources.stroke_7_1_2_0_cash_20_0_f1f1f1_none;
            this.cashboxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashboxButton.Location = new System.Drawing.Point(0, 137);
            this.cashboxButton.Name = "cashboxButton";
            this.cashboxButton.Size = new System.Drawing.Size(135, 30);
            this.cashboxButton.TabIndex = 1;
            this.cashboxButton.Text = "   Caja";
            this.cashboxButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashboxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cashboxButton.UseVisualStyleBackColor = false;
            this.cashboxButton.Click += new System.EventHandler(this.cashboxButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.clientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clientsButton.Image = global::OnlyIphone.Properties.Resources.ionicons_2_0_1_ios_people_20_0_f1f1f1_none;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.Location = new System.Drawing.Point(0, 173);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(135, 30);
            this.clientsButton.TabIndex = 2;
            this.clientsButton.Text = "   Clientes";
            this.clientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsButton.UseVisualStyleBackColor = false;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // providersButton
            // 
            this.providersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.providersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.providersButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.providersButton.FlatAppearance.BorderSize = 0;
            this.providersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.providersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.providersButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.providersButton.Image = global::OnlyIphone.Properties.Resources.icomoon_free_2014_12_23_truck_20_0_f1f1f1_none;
            this.providersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.providersButton.Location = new System.Drawing.Point(0, 317);
            this.providersButton.Name = "providersButton";
            this.providersButton.Size = new System.Drawing.Size(135, 30);
            this.providersButton.TabIndex = 8;
            this.providersButton.Text = "   Proveedores";
            this.providersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.providersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.providersButton.UseVisualStyleBackColor = false;
            this.providersButton.Click += new System.EventHandler(this.providersButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.salesButton.Image = global::OnlyIphone.Properties.Resources.material_icons_3_0_1_attach_money_20_0_f1f1f1_none;
            this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.Location = new System.Drawing.Point(0, 209);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(135, 30);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "   Ventas";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.usersButton.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_user_circle_o_20_0_f1f1f1_none1;
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(0, 281);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(135, 30);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "   Usuarios";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.productsButton.Image = global::OnlyIphone.Properties.Resources.iconic_1_1_1_box_20_0_f1f1f1_none;
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(0, 245);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(135, 30);
            this.productsButton.TabIndex = 4;
            this.productsButton.Text = "   Productos";
            this.productsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // btn_minimize_sidemenu
            // 
            this.btn_minimize_sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_minimize_sidemenu.FlatAppearance.BorderSize = 0;
            this.btn_minimize_sidemenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize_sidemenu.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_bars_20_0_f1f1f1_none;
            this.btn_minimize_sidemenu.Location = new System.Drawing.Point(135, 0);
            this.btn_minimize_sidemenu.Name = "btn_minimize_sidemenu";
            this.btn_minimize_sidemenu.Size = new System.Drawing.Size(28, 30);
            this.btn_minimize_sidemenu.TabIndex = 2;
            this.btn_minimize_sidemenu.UseVisualStyleBackColor = true;
            this.btn_minimize_sidemenu.Click += new System.EventHandler(this.btn_minimize_sidemenu_Click);
            // 
            // box_close
            // 
            this.box_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_close.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_power_off_20_0_f1f1f1_none;
            this.box_close.Location = new System.Drawing.Point(979, 5);
            this.box_close.Name = "box_close";
            this.box_close.Size = new System.Drawing.Size(18, 18);
            this.box_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_close.TabIndex = 0;
            this.box_close.TabStop = false;
            this.box_close.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // box_minimize
            // 
            this.box_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.box_minimize.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_window_minimize_20_0_f1f1f1_none;
            this.box_minimize.Location = new System.Drawing.Point(955, 6);
            this.box_minimize.Name = "box_minimize";
            this.box_minimize.Size = new System.Drawing.Size(18, 18);
            this.box_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box_minimize.TabIndex = 1;
            this.box_minimize.TabStop = false;
            this.box_minimize.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Main_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Windows";
            this.Text = "Main_Windows1";
            this.Load += new System.EventHandler(this.Main_Windows1_Load);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.menuPanelLogo.ResumeLayout(false);
            this.menuPanelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button cashboxButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button providersButton;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.PictureBox box_minimize;
        private System.Windows.Forms.PictureBox box_close;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_config;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel menuPanelLogo;
        private System.Windows.Forms.Button btn_minimize_sidemenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel status_dot;
        private System.Windows.Forms.PictureBox userPicture;
    }
}