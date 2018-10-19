namespace OnlyIphone
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.label_title_list = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_buscar = new System.Windows.Forms.Label();
            this.name_radioButton = new System.Windows.Forms.RadioButton();
            this.code_radioButton = new System.Windows.Forms.RadioButton();
            this.gridView_products = new System.Windows.Forms.DataGridView();
            this.button_disable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip_disable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_edit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_disabled_products = new System.Windows.Forms.ToolTip(this.components);
            this.button_getInventory = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_products)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title_list
            // 
            this.label_title_list.AutoSize = true;
            this.label_title_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_list.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_list.Location = new System.Drawing.Point(37, 30);
            this.label_title_list.Name = "label_title_list";
            this.label_title_list.Size = new System.Drawing.Size(257, 25);
            this.label_title_list.TabIndex = 27;
            this.label_title_list.Text = "Listado de Productos";
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_edit.Enabled = false;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_edit.Location = new System.Drawing.Point(634, -2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(65, 32);
            this.button_edit.TabIndex = 28;
            this.button_edit.Text = "Editar";
            this.toolTip_edit.SetToolTip(this.button_edit, "Click para editar la información del producto seleccionado.");
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textbox_search.Location = new System.Drawing.Point(3, 9);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(345, 14);
            this.textbox_search.TabIndex = 30;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            this.textbox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_search_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.Location = new System.Drawing.Point(61, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 32);
            this.panel1.TabIndex = 31;
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_buscar.Location = new System.Drawing.Point(3, 21);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 16);
            this.label_buscar.TabIndex = 32;
            this.label_buscar.Text = "Filtrar";
            // 
            // name_radioButton
            // 
            this.name_radioButton.AutoSize = true;
            this.name_radioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.name_radioButton.Location = new System.Drawing.Point(502, 19);
            this.name_radioButton.Name = "name_radioButton";
            this.name_radioButton.Size = new System.Drawing.Size(75, 20);
            this.name_radioButton.TabIndex = 34;
            this.name_radioButton.TabStop = true;
            this.name_radioButton.Text = "Nombre";
            this.name_radioButton.UseVisualStyleBackColor = true;
            // 
            // code_radioButton
            // 
            this.code_radioButton.AutoSize = true;
            this.code_radioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.code_radioButton.Location = new System.Drawing.Point(431, 19);
            this.code_radioButton.Name = "code_radioButton";
            this.code_radioButton.Size = new System.Drawing.Size(70, 20);
            this.code_radioButton.TabIndex = 33;
            this.code_radioButton.TabStop = true;
            this.code_radioButton.Text = "Código";
            this.code_radioButton.UseVisualStyleBackColor = true;
            this.code_radioButton.CheckedChanged += new System.EventHandler(this.code_radioButton_CheckedChanged);
            // 
            // gridView_products
            // 
            this.gridView_products.AllowUserToAddRows = false;
            this.gridView_products.AllowUserToDeleteRows = false;
            this.gridView_products.AllowUserToOrderColumns = true;
            this.gridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_products.BackgroundColor = System.Drawing.Color.White;
            this.gridView_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView_products.Location = new System.Drawing.Point(35, 138);
            this.gridView_products.Name = "gridView_products";
            this.gridView_products.ReadOnly = true;
            this.gridView_products.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.gridView_products.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView_products.Size = new System.Drawing.Size(795, 321);
            this.gridView_products.TabIndex = 35;
            this.gridView_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_products_CellClick);
            // 
            // button_disable
            // 
            this.button_disable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.button_disable.Enabled = false;
            this.button_disable.FlatAppearance.BorderSize = 0;
            this.button_disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_disable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disable.ForeColor = System.Drawing.Color.White;
            this.button_disable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_disable.Location = new System.Drawing.Point(705, -2);
            this.button_disable.Name = "button_disable";
            this.button_disable.Size = new System.Drawing.Size(90, 32);
            this.button_disable.TabIndex = 38;
            this.button_disable.Text = "Deshabilitar";
            this.toolTip_disable.SetToolTip(this.button_disable, "Deshabilita el producto seleccionado. Ya no se mostrará en el listado.");
            this.button_disable.UseVisualStyleBackColor = false;
            this.button_disable.Click += new System.EventHandler(this.button_disable_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(634, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 45);
            this.button3.TabIndex = 39;
            this.button3.Text = "Productos \r\nDeshabilitados";
            this.toolTip_disabled_products.SetToolTip(this.button3, "Click para abrir el listado de productos deshabilitados.");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_getInventory
            // 
            this.button_getInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_getInventory.FlatAppearance.BorderSize = 0;
            this.button_getInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_getInventory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_getInventory.ForeColor = System.Drawing.Color.White;
            this.button_getInventory.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_truck_25_0_f1f1f1_none;
            this.button_getInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_getInventory.Location = new System.Drawing.Point(719, 30);
            this.button_getInventory.Name = "button_getInventory";
            this.button_getInventory.Size = new System.Drawing.Size(111, 36);
            this.button_getInventory.TabIndex = 40;
            this.button_getInventory.Text = "Solicitar inventario";
            this.button_getInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_getInventory.UseVisualStyleBackColor = false;
            this.button_getInventory.Click += new System.EventHandler(this.button_getInventory_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.ForeColor = System.Drawing.Color.White;
            this.addCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("addCategoryButton.Image")));
            this.addCategoryButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCategoryButton.Location = new System.Drawing.Point(162, 0);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(75, 70);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "Agregar\r\nCategoría";
            this.addCategoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addTypeButton
            // 
            this.addTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.addTypeButton.FlatAppearance.BorderSize = 0;
            this.addTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTypeButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeButton.ForeColor = System.Drawing.Color.White;
            this.addTypeButton.Image = ((System.Drawing.Image)(resources.GetObject("addTypeButton.Image")));
            this.addTypeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTypeButton.Location = new System.Drawing.Point(81, 0);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(75, 70);
            this.addTypeButton.TabIndex = 2;
            this.addTypeButton.Text = "Agregar\r\nTipo";
            this.addTypeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTypeButton.UseVisualStyleBackColor = false;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.Color.White;
            this.addProductButton.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.Image")));
            this.addProductButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addProductButton.Location = new System.Drawing.Point(0, 0);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 70);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Agregar\r\nProducto";
            this.addProductButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.panel1);
            this.filterPanel.Controls.Add(this.label_buscar);
            this.filterPanel.Controls.Add(this.code_radioButton);
            this.filterPanel.Controls.Add(this.name_radioButton);
            this.filterPanel.Location = new System.Drawing.Point(35, 80);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(795, 52);
            this.filterPanel.TabIndex = 41;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.addProductButton);
            this.buttonPanel.Controls.Add(this.addTypeButton);
            this.buttonPanel.Controls.Add(this.addCategoryButton);
            this.buttonPanel.Controls.Add(this.button3);
            this.buttonPanel.Controls.Add(this.button_disable);
            this.buttonPanel.Controls.Add(this.button_edit);
            this.buttonPanel.Location = new System.Drawing.Point(35, 467);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(795, 82);
            this.buttonPanel.TabIndex = 42;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.button_getInventory);
            this.Controls.Add(this.gridView_products);
            this.Controls.Add(this.label_title_list);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "products";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.products_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.products_Paint);
            this.Resize += new System.EventHandler(this.products_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_products)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label label_title_list;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.RadioButton name_radioButton;
        private System.Windows.Forms.RadioButton code_radioButton;
        private System.Windows.Forms.DataGridView gridView_products;
        private System.Windows.Forms.Button button_disable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip_disable;
        private System.Windows.Forms.ToolTip toolTip_edit;
        private System.Windows.Forms.ToolTip toolTip_disabled_products;
        private System.Windows.Forms.Button button_getInventory;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel buttonPanel;
    }
}
