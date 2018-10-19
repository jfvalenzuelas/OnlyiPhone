namespace OnlyIphone
{
    partial class providers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView_providers = new System.Windows.Forms.DataGridView();
            this.dayNameLabel = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_buscar = new System.Windows.Forms.Label();
            this.name_radioButton = new System.Windows.Forms.RadioButton();
            this.button_disable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip_disabled_providers = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_disable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_edit = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_providers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView_providers
            // 
            this.gridView_providers.AllowUserToAddRows = false;
            this.gridView_providers.AllowUserToDeleteRows = false;
            this.gridView_providers.AllowUserToOrderColumns = true;
            this.gridView_providers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_providers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_providers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView_providers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_providers.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridView_providers.GridColor = System.Drawing.SystemColors.Control;
            this.gridView_providers.Location = new System.Drawing.Point(27, 112);
            this.gridView_providers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridView_providers.Name = "gridView_providers";
            this.gridView_providers.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_providers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridView_providers.RowHeadersWidth = 100;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.gridView_providers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridView_providers.Size = new System.Drawing.Size(813, 326);
            this.gridView_providers.TabIndex = 1;
            this.gridView_providers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_providers_CellClick);
            // 
            // dayNameLabel
            // 
            this.dayNameLabel.AutoSize = true;
            this.dayNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dayNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dayNameLabel.Location = new System.Drawing.Point(37, 30);
            this.dayNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayNameLabel.Name = "dayNameLabel";
            this.dayNameLabel.Size = new System.Drawing.Size(286, 25);
            this.dayNameLabel.TabIndex = 26;
            this.dayNameLabel.Text = "Listado de Proveedores";
            this.dayNameLabel.Click += new System.EventHandler(this.dayNameLabel_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.BackColor = System.Drawing.Color.White;
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textbox_search.Location = new System.Drawing.Point(3, 5);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(255, 14);
            this.textbox_search.TabIndex = 30;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            this.textbox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_search_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.Location = new System.Drawing.Point(77, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 24);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button_edit.Location = new System.Drawing.Point(671, 1);
            this.button_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(49, 24);
            this.button_edit.TabIndex = 33;
            this.button_edit.Text = "Editar";
            this.toolTip_edit.SetToolTip(this.button_edit, "Click para editar la información del proveedor seleccionado.");
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_buscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_buscar.Location = new System.Drawing.Point(24, 71);
            this.label_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 16);
            this.label_buscar.TabIndex = 33;
            this.label_buscar.Text = "Filtrar";
            this.label_buscar.Click += new System.EventHandler(this.label_buscar_Click);
            // 
            // name_radioButton
            // 
            this.name_radioButton.AutoSize = true;
            this.name_radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.name_radioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.name_radioButton.Location = new System.Drawing.Point(351, 71);
            this.name_radioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_radioButton.Name = "name_radioButton";
            this.name_radioButton.Size = new System.Drawing.Size(75, 20);
            this.name_radioButton.TabIndex = 36;
            this.name_radioButton.TabStop = true;
            this.name_radioButton.Text = "Nombre";
            this.name_radioButton.UseVisualStyleBackColor = false;
            this.name_radioButton.CheckedChanged += new System.EventHandler(this.name_radioButton_CheckedChanged);
            // 
            // button_disable
            // 
            this.button_disable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button_disable.Enabled = false;
            this.button_disable.FlatAppearance.BorderSize = 0;
            this.button_disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_disable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disable.ForeColor = System.Drawing.Color.White;
            this.button_disable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_disable.Location = new System.Drawing.Point(724, 0);
            this.button_disable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_disable.Name = "button_disable";
            this.button_disable.Size = new System.Drawing.Size(89, 24);
            this.button_disable.TabIndex = 37;
            this.button_disable.Text = "Deshabilitar";
            this.toolTip_disable.SetToolTip(this.button_disable, "Deshabilita el proveedor seleccionado. Ya no se mostrará en el listado.");
            this.button_disable.UseVisualStyleBackColor = false;
            this.button_disable.Click += new System.EventHandler(this.button_disable_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(671, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 38;
            this.button3.Text = "Proveedores\r\nDeshabilitados";
            this.toolTip_disabled_providers.SetToolTip(this.button3, "Click para abrir el listado de proveedores deshabilitados.");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label_buscar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 103);
            this.panel2.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_add_25_0_f1f1f1_none2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar\r\nProveedor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.button1);
            this.buttonPanel.Controls.Add(this.button3);
            this.buttonPanel.Controls.Add(this.button_disable);
            this.buttonPanel.Controls.Add(this.button_edit);
            this.buttonPanel.Location = new System.Drawing.Point(27, 443);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(813, 71);
            this.buttonPanel.TabIndex = 55;
            // 
            // providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.name_radioButton);
            this.Controls.Add(this.dayNameLabel);
            this.Controls.Add(this.gridView_providers);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "providers";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.providers_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.providers_Paint);
            this.Resize += new System.EventHandler(this.providers_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_providers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridView_providers;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.RadioButton name_radioButton;
        private System.Windows.Forms.Button button_disable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip_disabled_providers;
        private System.Windows.Forms.ToolTip toolTip_disable;
        private System.Windows.Forms.ToolTip toolTip_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel buttonPanel;
    }
}
