namespace OnlyIphone
{
    partial class addWorkOrder
    {
 
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addWorkOrder));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.gridView_products = new System.Windows.Forms.DataGridView();
            this.textbox_searchProduct = new System.Windows.Forms.TextBox();
            this.radioButton_description = new System.Windows.Forms.RadioButton();
            this.radioButton_code = new System.Windows.Forms.RadioButton();
            this.label_findproduct = new System.Windows.Forms.Label();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.label_user = new System.Windows.Forms.Label();
            this.label_detail = new System.Windows.Forms.Label();
            this.gridView_detail = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_findClient = new System.Windows.Forms.Button();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_addClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_descuento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_descuento = new System.Windows.Forms.TextBox();
            this.label_subTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_paymentMethods = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_subtractCount = new System.Windows.Forms.Button();
            this.button_sumCount = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_addDetail = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_products)).BeginInit();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(27)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(950, 20);
            this.headerPanel.TabIndex = 17;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // textBox_description
            // 
            this.textBox_description.BackColor = System.Drawing.Color.White;
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Location = new System.Drawing.Point(426, 348);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(172, 174);
            this.textBox_description.TabIndex = 18;
            // 
            // gridView_products
            // 
            this.gridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_products.BackgroundColor = System.Drawing.Color.White;
            this.gridView_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_products.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridView_products.Location = new System.Drawing.Point(12, 82);
            this.gridView_products.Name = "gridView_products";
            this.gridView_products.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.gridView_products.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView_products.Size = new System.Drawing.Size(524, 168);
            this.gridView_products.TabIndex = 19;
            this.gridView_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_products_CellClick);
            // 
            // textbox_searchProduct
            // 
            this.textbox_searchProduct.BackColor = System.Drawing.Color.White;
            this.textbox_searchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_searchProduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_searchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textbox_searchProduct.Location = new System.Drawing.Point(3, 4);
            this.textbox_searchProduct.Name = "textbox_searchProduct";
            this.textbox_searchProduct.Size = new System.Drawing.Size(238, 14);
            this.textbox_searchProduct.TabIndex = 36;
            this.textbox_searchProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_searchProduct_KeyUp);
            // 
            // radioButton_description
            // 
            this.radioButton_description.AutoSize = true;
            this.radioButton_description.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radioButton_description.Location = new System.Drawing.Point(448, 50);
            this.radioButton_description.Name = "radioButton_description";
            this.radioButton_description.Size = new System.Drawing.Size(91, 17);
            this.radioButton_description.TabIndex = 38;
            this.radioButton_description.TabStop = true;
            this.radioButton_description.Text = "Descripción";
            this.radioButton_description.UseVisualStyleBackColor = true;
            // 
            // radioButton_code
            // 
            this.radioButton_code.AutoSize = true;
            this.radioButton_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radioButton_code.Location = new System.Drawing.Point(382, 50);
            this.radioButton_code.Name = "radioButton_code";
            this.radioButton_code.Size = new System.Drawing.Size(65, 17);
            this.radioButton_code.TabIndex = 37;
            this.radioButton_code.TabStop = true;
            this.radioButton_code.Text = "Código";
            this.radioButton_code.UseVisualStyleBackColor = true;
            // 
            // label_findproduct
            // 
            this.label_findproduct.AutoSize = true;
            this.label_findproduct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_findproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_findproduct.Location = new System.Drawing.Point(13, 51);
            this.label_findproduct.Name = "label_findproduct";
            this.label_findproduct.Size = new System.Drawing.Size(114, 14);
            this.label_findproduct.TabIndex = 35;
            this.label_findproduct.Text = "Buscar producto";
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.White;
            this.panel_Search.Controls.Add(this.textbox_searchProduct);
            this.panel_Search.Location = new System.Drawing.Point(131, 46);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(245, 25);
            this.panel_Search.TabIndex = 39;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_user.Location = new System.Drawing.Point(765, 46);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(66, 16);
            this.label_user.TabIndex = 42;
            this.label_user.Text = "Cantidad";
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_detail.Location = new System.Drawing.Point(556, 41);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(95, 25);
            this.label_detail.TabIndex = 41;
            this.label_detail.Text = "Detalle";
            // 
            // gridView_detail
            // 
            this.gridView_detail.AllowUserToAddRows = false;
            this.gridView_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_detail.BackgroundColor = System.Drawing.Color.White;
            this.gridView_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView_detail.Location = new System.Drawing.Point(561, 82);
            this.gridView_detail.Name = "gridView_detail";
            this.gridView_detail.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.gridView_detail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView_detail.Size = new System.Drawing.Size(366, 168);
            this.gridView_detail.TabIndex = 40;
            this.gridView_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_detail_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_findClient);
            this.groupBox2.Controls.Add(this.textBox_address);
            this.groupBox2.Controls.Add(this.textBox_phone);
            this.groupBox2.Controls.Add(this.textBox_email);
            this.groupBox2.Controls.Add(this.textBox_lastName);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_rut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button_addClient);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 205);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // button_findClient
            // 
            this.button_findClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button_findClient.FlatAppearance.BorderSize = 0;
            this.button_findClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_findClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findClient.ForeColor = System.Drawing.Color.White;
            this.button_findClient.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_search_25_0_f1f1f1_none;
            this.button_findClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_findClient.Location = new System.Drawing.Point(285, 21);
            this.button_findClient.Name = "button_findClient";
            this.button_findClient.Size = new System.Drawing.Size(96, 38);
            this.button_findClient.TabIndex = 46;
            this.button_findClient.Text = "Buscar";
            this.button_findClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_findClient.UseVisualStyleBackColor = false;
            this.button_findClient.Click += new System.EventHandler(this.button_findClient_Click);
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.White;
            this.textBox_address.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(77, 173);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(157, 21);
            this.textBox_address.TabIndex = 45;
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = System.Drawing.Color.White;
            this.textBox_phone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(77, 143);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(157, 21);
            this.textBox_phone.TabIndex = 44;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.White;
            this.textBox_email.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(78, 112);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(156, 21);
            this.textBox_email.TabIndex = 43;
            this.textBox_email.Leave += new System.EventHandler(this.textBox_email_Leave);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.BackColor = System.Drawing.Color.White;
            this.textBox_lastName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastName.Location = new System.Drawing.Point(78, 81);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(156, 21);
            this.textBox_lastName.TabIndex = 42;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(78, 50);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(156, 21);
            this.textBox_name.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // textBox_rut
            // 
            this.textBox_rut.BackColor = System.Drawing.Color.White;
            this.textBox_rut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rut.Location = new System.Drawing.Point(78, 21);
            this.textBox_rut.Name = "textBox_rut";
            this.textBox_rut.Size = new System.Drawing.Size(156, 21);
            this.textBox_rut.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox_rut, "Sin guión ni puntos (Ej: 123456789)");
            this.textBox_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_rut_KeyPress);
            this.textBox_rut.Leave += new System.EventHandler(this.textBox_rut_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Apellido";
            // 
            // button_addClient
            // 
            this.button_addClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_addClient.FlatAppearance.BorderSize = 0;
            this.button_addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addClient.ForeColor = System.Drawing.Color.White;
            this.button_addClient.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_add_25_0_f1f1f1_none1;
            this.button_addClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addClient.Location = new System.Drawing.Point(285, 71);
            this.button_addClient.Name = "button_addClient";
            this.button_addClient.Size = new System.Drawing.Size(96, 38);
            this.button_addClient.TabIndex = 16;
            this.button_addClient.Text = "Nuevo";
            this.button_addClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addClient.UseVisualStyleBackColor = false;
            this.button_addClient.Click += new System.EventHandler(this.button_addClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_descuento);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_descuento);
            this.groupBox1.Controls.Add(this.label_subTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_paymentMethods);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_total);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(616, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 205);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen de la orden de trabajo";
            // 
            // button_descuento
            // 
            this.button_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button_descuento.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_descuento.FlatAppearance.BorderSize = 0;
            this.button_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_descuento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_descuento.ForeColor = System.Drawing.Color.White;
            this.button_descuento.Location = new System.Drawing.Point(277, 49);
            this.button_descuento.Name = "button_descuento";
            this.button_descuento.Size = new System.Drawing.Size(20, 21);
            this.button_descuento.TabIndex = 39;
            this.button_descuento.Text = "X";
            this.button_descuento.UseVisualStyleBackColor = false;
            this.button_descuento.Visible = false;
            this.button_descuento.Click += new System.EventHandler(this.button_descuento_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(205, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 21);
            this.button1.TabIndex = 38;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Image = global::OnlyIphone.Properties.Resources.typicons_2_0_7_cancel_25_0_f1f1f1_none;
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(14, 143);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 46);
            this.button_cancel.TabIndex = 17;
            this.button_cancel.Text = "Cancelar Orden";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mano de obra";
            // 
            // textBox_descuento
            // 
            this.textBox_descuento.BackColor = System.Drawing.Color.White;
            this.textBox_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_descuento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descuento.Location = new System.Drawing.Point(127, 49);
            this.textBox_descuento.Name = "textBox_descuento";
            this.textBox_descuento.Size = new System.Drawing.Size(73, 21);
            this.textBox_descuento.TabIndex = 9;
            this.textBox_descuento.Text = "0";
            this.textBox_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_descuento_KeyPress);
            // 
            // label_subTotal
            // 
            this.label_subTotal.AutoSize = true;
            this.label_subTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subTotal.Location = new System.Drawing.Point(127, 24);
            this.label_subTotal.Name = "label_subTotal";
            this.label_subTotal.Size = new System.Drawing.Size(27, 14);
            this.label_subTotal.TabIndex = 10;
            this.label_subTotal.Text = "$ 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Método de pago";
            // 
            // comboBox_paymentMethods
            // 
            this.comboBox_paymentMethods.BackColor = System.Drawing.Color.White;
            this.comboBox_paymentMethods.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_paymentMethods.FormattingEnabled = true;
            this.comboBox_paymentMethods.Location = new System.Drawing.Point(127, 107);
            this.comboBox_paymentMethods.Name = "comboBox_paymentMethods";
            this.comboBox_paymentMethods.Size = new System.Drawing.Size(170, 21);
            this.comboBox_paymentMethods.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(127, 84);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(27, 14);
            this.label_total.TabIndex = 14;
            this.label_total.Text = "$ 0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_addnew_25_0_f1f1f1_none;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(179, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ingresar Orden";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(423, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "Descripción";
            // 
            // button_subtractCount
            // 
            this.button_subtractCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.button_subtractCount.Enabled = false;
            this.button_subtractCount.FlatAppearance.BorderSize = 0;
            this.button_subtractCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subtractCount.Location = new System.Drawing.Point(887, 263);
            this.button_subtractCount.Name = "button_subtractCount";
            this.button_subtractCount.Size = new System.Drawing.Size(28, 26);
            this.button_subtractCount.TabIndex = 50;
            this.button_subtractCount.Text = "-";
            this.button_subtractCount.UseVisualStyleBackColor = false;
            this.button_subtractCount.Click += new System.EventHandler(this.button_subtractCount_Click);
            // 
            // button_sumCount
            // 
            this.button_sumCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.button_sumCount.Enabled = false;
            this.button_sumCount.FlatAppearance.BorderSize = 0;
            this.button_sumCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sumCount.Location = new System.Drawing.Point(854, 263);
            this.button_sumCount.Name = "button_sumCount";
            this.button_sumCount.Size = new System.Drawing.Size(27, 26);
            this.button_sumCount.TabIndex = 49;
            this.button_sumCount.Text = "+";
            this.button_sumCount.UseVisualStyleBackColor = false;
            this.button_sumCount.Click += new System.EventHandler(this.button_sumCount_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(782, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Cantidad";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::OnlyIphone.Properties.Resources.ionicons_2_0_1_android_delete_25_0_f1f1f1_none1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(561, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 44;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_addDetail
            // 
            this.button_addDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_addDetail.Enabled = false;
            this.button_addDetail.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_addDetail.FlatAppearance.BorderSize = 0;
            this.button_addDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addDetail.ForeColor = System.Drawing.Color.White;
            this.button_addDetail.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_add_25_0_f1f1f1_none1;
            this.button_addDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addDetail.Location = new System.Drawing.Point(12, 257);
            this.button_addDetail.Name = "button_addDetail";
            this.button_addDetail.Size = new System.Drawing.Size(110, 40);
            this.button_addDetail.TabIndex = 43;
            this.button_addDetail.Text = "Agregar";
            this.button_addDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addDetail.UseVisualStyleBackColor = false;
            this.button_addDetail.Click += new System.EventHandler(this.button_addDetail_Click);
            // 
            // addWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 534);
            this.Controls.Add(this.button_subtractCount);
            this.Controls.Add(this.button_sumCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_addDetail);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_detail);
            this.Controls.Add(this.gridView_detail);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.radioButton_description);
            this.Controls.Add(this.radioButton_code);
            this.Controls.Add(this.label_findproduct);
            this.Controls.Add(this.gridView_products);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addWorkOrder";
            this.Text = "addWorkOrder";
            this.Load += new System.EventHandler(this.addWorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_products)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.DataGridView gridView_products;
        private System.Windows.Forms.TextBox textbox_searchProduct;
        private System.Windows.Forms.RadioButton radioButton_description;
        private System.Windows.Forms.RadioButton radioButton_code;
        private System.Windows.Forms.Label label_findproduct;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.DataGridView gridView_detail;
        private System.Windows.Forms.Button button_addDetail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_findClient;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_addClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_descuento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_descuento;
        private System.Windows.Forms.Label label_subTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_paymentMethods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_subtractCount;
        private System.Windows.Forms.Button button_sumCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}