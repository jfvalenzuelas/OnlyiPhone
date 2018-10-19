namespace OnlyIphone
{
    partial class addProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProducts));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salepriceTextBox = new System.Windows.Forms.TextBox();
            this.buyedpriceTextBox = new System.Windows.Forms.TextBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label_code = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_sale = new System.Windows.Forms.Label();
            this.label_buyed = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_provider = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.stocknumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.desirednumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.desiredCrossPictureBox = new System.Windows.Forms.PictureBox();
            this.categorycrossPictureBox = new System.Windows.Forms.PictureBox();
            this.typecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.providercrossPictureBox = new System.Windows.Forms.PictureBox();
            this.stockcrossPictureBox = new System.Windows.Forms.PictureBox();
            this.buyedpricecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.salepricecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.namecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.codecrossPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocknumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desirednumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredCrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorycrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providercrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockcrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyedpricecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salepricecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namecrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codecrossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(27)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 20);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.White;
            this.codeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.codeTextBox.Location = new System.Drawing.Point(144, 61);
            this.codeTextBox.MaxLength = 6;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(201, 20);
            this.codeTextBox.TabIndex = 2;
            this.codeTextBox.Leave += new System.EventHandler(this.codeTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nameTextBox.Location = new System.Drawing.Point(144, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // salepriceTextBox
            // 
            this.salepriceTextBox.BackColor = System.Drawing.Color.White;
            this.salepriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.salepriceTextBox.Location = new System.Drawing.Point(144, 113);
            this.salepriceTextBox.Name = "salepriceTextBox";
            this.salepriceTextBox.Size = new System.Drawing.Size(201, 20);
            this.salepriceTextBox.TabIndex = 4;
            this.salepriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salepriceTextBox_KeyPress);
            this.salepriceTextBox.Leave += new System.EventHandler(this.salepriceTextBox_Leave);
            // 
            // buyedpriceTextBox
            // 
            this.buyedpriceTextBox.BackColor = System.Drawing.Color.White;
            this.buyedpriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buyedpriceTextBox.Location = new System.Drawing.Point(144, 139);
            this.buyedpriceTextBox.Name = "buyedpriceTextBox";
            this.buyedpriceTextBox.Size = new System.Drawing.Size(201, 20);
            this.buyedpriceTextBox.TabIndex = 5;
            this.buyedpriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyedpriceTextBox_KeyPress);
            this.buyedpriceTextBox.Leave += new System.EventHandler(this.buyedpriceTextBox_Leave);
            // 
            // providerComboBox
            // 
            this.providerComboBox.BackColor = System.Drawing.Color.White;
            this.providerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(144, 216);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(201, 21);
            this.providerComboBox.TabIndex = 7;
            this.providerComboBox.Leave += new System.EventHandler(this.providerComboBox_Leave);
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.White;
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(144, 243);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(201, 21);
            this.typeComboBox.TabIndex = 8;
            this.typeComboBox.Leave += new System.EventHandler(this.typeComboBox_Leave);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.White;
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(144, 270);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(201, 21);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.Leave += new System.EventHandler(this.categoryComboBox_Leave);
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_code.Location = new System.Drawing.Point(12, 62);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(52, 16);
            this.label_code.TabIndex = 10;
            this.label_code.Text = "Código";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_name.Location = new System.Drawing.Point(12, 88);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 16);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Nombre";
            // 
            // label_sale
            // 
            this.label_sale.AutoSize = true;
            this.label_sale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_sale.Location = new System.Drawing.Point(12, 114);
            this.label_sale.Name = "label_sale";
            this.label_sale.Size = new System.Drawing.Size(112, 16);
            this.label_sale.TabIndex = 12;
            this.label_sale.Text = "Precio de venta";
            // 
            // label_buyed
            // 
            this.label_buyed.AutoSize = true;
            this.label_buyed.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buyed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_buyed.Location = new System.Drawing.Point(12, 140);
            this.label_buyed.Name = "label_buyed";
            this.label_buyed.Size = new System.Drawing.Size(122, 16);
            this.label_buyed.TabIndex = 13;
            this.label_buyed.Text = "Precio de compra";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_stock.Location = new System.Drawing.Point(12, 166);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(66, 16);
            this.label_stock.TabIndex = 14;
            this.label_stock.Text = "Cantidad";
            // 
            // label_provider
            // 
            this.label_provider.AutoSize = true;
            this.label_provider.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_provider.Location = new System.Drawing.Point(12, 217);
            this.label_provider.Name = "label_provider";
            this.label_provider.Size = new System.Drawing.Size(74, 16);
            this.label_provider.TabIndex = 15;
            this.label_provider.Text = "Proveedor";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_type.Location = new System.Drawing.Point(12, 244);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(36, 16);
            this.label_type.TabIndex = 16;
            this.label_type.Text = "Tipo";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_category.Location = new System.Drawing.Point(12, 271);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(71, 16);
            this.label_category.TabIndex = 17;
            this.label_category.Text = "Categoría";
            // 
            // stocknumericUpDown
            // 
            this.stocknumericUpDown.BackColor = System.Drawing.Color.White;
            this.stocknumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.stocknumericUpDown.Location = new System.Drawing.Point(144, 166);
            this.stocknumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stocknumericUpDown.Name = "stocknumericUpDown";
            this.stocknumericUpDown.Size = new System.Drawing.Size(201, 20);
            this.stocknumericUpDown.TabIndex = 18;
            this.stocknumericUpDown.Leave += new System.EventHandler(this.stocknumericUpDown_Leave);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(189, 313);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 25);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(270, 313);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 25);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Agregar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title.Location = new System.Drawing.Point(11, 23);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(161, 23);
            this.label_title.TabIndex = 37;
            this.label_title.Text = "Nuevo Producto";
            // 
            // desirednumericUpDown
            // 
            this.desirednumericUpDown.BackColor = System.Drawing.Color.White;
            this.desirednumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.desirednumericUpDown.Location = new System.Drawing.Point(144, 192);
            this.desirednumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.desirednumericUpDown.Name = "desirednumericUpDown";
            this.desirednumericUpDown.Size = new System.Drawing.Size(201, 20);
            this.desirednumericUpDown.TabIndex = 39;
            this.desirednumericUpDown.Leave += new System.EventHandler(this.desirednumericUpDown_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cantidad deseada";
            // 
            // desiredCrossPictureBox
            // 
            this.desiredCrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("desiredCrossPictureBox.Image")));
            this.desiredCrossPictureBox.Location = new System.Drawing.Point(355, 195);
            this.desiredCrossPictureBox.Name = "desiredCrossPictureBox";
            this.desiredCrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.desiredCrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.desiredCrossPictureBox.TabIndex = 40;
            this.desiredCrossPictureBox.TabStop = false;
            this.desiredCrossPictureBox.Visible = false;
            // 
            // categorycrossPictureBox
            // 
            this.categorycrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("categorycrossPictureBox.Image")));
            this.categorycrossPictureBox.Location = new System.Drawing.Point(355, 272);
            this.categorycrossPictureBox.Name = "categorycrossPictureBox";
            this.categorycrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.categorycrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categorycrossPictureBox.TabIndex = 36;
            this.categorycrossPictureBox.TabStop = false;
            this.categorycrossPictureBox.Visible = false;
            // 
            // typecrossPictureBox
            // 
            this.typecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("typecrossPictureBox.Image")));
            this.typecrossPictureBox.Location = new System.Drawing.Point(355, 246);
            this.typecrossPictureBox.Name = "typecrossPictureBox";
            this.typecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.typecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typecrossPictureBox.TabIndex = 35;
            this.typecrossPictureBox.TabStop = false;
            this.typecrossPictureBox.Visible = false;
            // 
            // providercrossPictureBox
            // 
            this.providercrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("providercrossPictureBox.Image")));
            this.providercrossPictureBox.Location = new System.Drawing.Point(355, 220);
            this.providercrossPictureBox.Name = "providercrossPictureBox";
            this.providercrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.providercrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.providercrossPictureBox.TabIndex = 34;
            this.providercrossPictureBox.TabStop = false;
            this.providercrossPictureBox.Visible = false;
            // 
            // stockcrossPictureBox
            // 
            this.stockcrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("stockcrossPictureBox.Image")));
            this.stockcrossPictureBox.Location = new System.Drawing.Point(355, 169);
            this.stockcrossPictureBox.Name = "stockcrossPictureBox";
            this.stockcrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.stockcrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stockcrossPictureBox.TabIndex = 33;
            this.stockcrossPictureBox.TabStop = false;
            this.stockcrossPictureBox.Visible = false;
            // 
            // buyedpricecrossPictureBox
            // 
            this.buyedpricecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("buyedpricecrossPictureBox.Image")));
            this.buyedpricecrossPictureBox.Location = new System.Drawing.Point(355, 142);
            this.buyedpricecrossPictureBox.Name = "buyedpricecrossPictureBox";
            this.buyedpricecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.buyedpricecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buyedpricecrossPictureBox.TabIndex = 32;
            this.buyedpricecrossPictureBox.TabStop = false;
            this.buyedpricecrossPictureBox.Visible = false;
            // 
            // salepricecrossPictureBox
            // 
            this.salepricecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("salepricecrossPictureBox.Image")));
            this.salepricecrossPictureBox.Location = new System.Drawing.Point(355, 116);
            this.salepricecrossPictureBox.Name = "salepricecrossPictureBox";
            this.salepricecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.salepricecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salepricecrossPictureBox.TabIndex = 31;
            this.salepricecrossPictureBox.TabStop = false;
            this.salepricecrossPictureBox.Visible = false;
            // 
            // namecrossPictureBox
            // 
            this.namecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("namecrossPictureBox.Image")));
            this.namecrossPictureBox.Location = new System.Drawing.Point(355, 88);
            this.namecrossPictureBox.Name = "namecrossPictureBox";
            this.namecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.namecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namecrossPictureBox.TabIndex = 30;
            this.namecrossPictureBox.TabStop = false;
            this.namecrossPictureBox.Visible = false;
            // 
            // codecrossPictureBox
            // 
            this.codecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("codecrossPictureBox.Image")));
            this.codecrossPictureBox.Location = new System.Drawing.Point(355, 61);
            this.codecrossPictureBox.Name = "codecrossPictureBox";
            this.codecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.codecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codecrossPictureBox.TabIndex = 29;
            this.codecrossPictureBox.TabStop = false;
            this.codecrossPictureBox.Visible = false;
            // 
            // addProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.desiredCrossPictureBox);
            this.Controls.Add(this.desirednumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.categorycrossPictureBox);
            this.Controls.Add(this.typecrossPictureBox);
            this.Controls.Add(this.providercrossPictureBox);
            this.Controls.Add(this.stockcrossPictureBox);
            this.Controls.Add(this.buyedpricecrossPictureBox);
            this.Controls.Add(this.salepricecrossPictureBox);
            this.Controls.Add(this.namecrossPictureBox);
            this.Controls.Add(this.codecrossPictureBox);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.stocknumericUpDown);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_provider);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_buyed);
            this.Controls.Add(this.label_sale);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.buyedpriceTextBox);
            this.Controls.Add(this.salepriceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProducts";
            this.Text = "addProducts";
            this.Load += new System.EventHandler(this.addProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocknumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desirednumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desiredCrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorycrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providercrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockcrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyedpricecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salepricecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codecrossPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox salepriceTextBox;
        private System.Windows.Forms.TextBox buyedpriceTextBox;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_sale;
        private System.Windows.Forms.Label label_buyed;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label_provider;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.NumericUpDown stocknumericUpDown;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox namecrossPictureBox;
        private System.Windows.Forms.PictureBox salepricecrossPictureBox;
        private System.Windows.Forms.PictureBox providercrossPictureBox;
        private System.Windows.Forms.PictureBox stockcrossPictureBox;
        private System.Windows.Forms.PictureBox buyedpricecrossPictureBox;
        private System.Windows.Forms.PictureBox categorycrossPictureBox;
        private System.Windows.Forms.PictureBox typecrossPictureBox;
        private System.Windows.Forms.PictureBox codecrossPictureBox;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox desiredCrossPictureBox;
        private System.Windows.Forms.NumericUpDown desirednumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}