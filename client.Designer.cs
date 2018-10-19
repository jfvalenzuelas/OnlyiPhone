namespace OnlyIphone
{
    partial class client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_buscar = new System.Windows.Forms.Label();
            this.label_title_list = new System.Windows.Forms.Label();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.gridView_clients = new System.Windows.Forms.DataGridView();
            this.code_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_clients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_buscar.Location = new System.Drawing.Point(39, 80);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(52, 16);
            this.label_buscar.TabIndex = 38;
            this.label_buscar.Text = "Filtrar";
            // 
            // label_title_list
            // 
            this.label_title_list.AutoSize = true;
            this.label_title_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_list.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_list.Location = new System.Drawing.Point(37, 23);
            this.label_title_list.Name = "label_title_list";
            this.label_title_list.Size = new System.Drawing.Size(234, 25);
            this.label_title_list.TabIndex = 36;
            this.label_title_list.Text = "Listado de Clientes";
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
            this.textbox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_search_KeyUp);
            // 
            // gridView_clients
            // 
            this.gridView_clients.AllowUserToAddRows = false;
            this.gridView_clients.AllowUserToDeleteRows = false;
            this.gridView_clients.AllowUserToOrderColumns = true;
            this.gridView_clients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.NullValue = "--";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.gridView_clients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_clients.BackgroundColor = System.Drawing.Color.White;
            this.gridView_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView_clients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.gridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_clients.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView_clients.GridColor = System.Drawing.Color.White;
            this.gridView_clients.Location = new System.Drawing.Point(42, 109);
            this.gridView_clients.Name = "gridView_clients";
            this.gridView_clients.ReadOnly = true;
            this.gridView_clients.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.gridView_clients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView_clients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_clients.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gridView_clients.RowTemplate.DefaultCellStyle.NullValue = "--";
            this.gridView_clients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.gridView_clients.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridView_clients.Size = new System.Drawing.Size(789, 366);
            this.gridView_clients.TabIndex = 41;
            // 
            // code_radioButton
            // 
            this.code_radioButton.AutoSize = true;
            this.code_radioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.code_radioButton.Location = new System.Drawing.Point(467, 78);
            this.code_radioButton.Name = "code_radioButton";
            this.code_radioButton.Size = new System.Drawing.Size(48, 20);
            this.code_radioButton.TabIndex = 39;
            this.code_radioButton.TabStop = true;
            this.code_radioButton.Text = "Rut";
            this.code_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textbox_search);
            this.panel1.Location = new System.Drawing.Point(97, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 32);
            this.panel1.TabIndex = 37;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.label_buscar);
            this.Controls.Add(this.label_title_list);
            this.Controls.Add(this.gridView_clients);
            this.Controls.Add(this.code_radioButton);
            this.Controls.Add(this.panel1);
            this.Name = "client";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.client_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.client_Paint);
            this.Resize += new System.EventHandler(this.client_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_clients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.Label label_title_list;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.DataGridView gridView_clients;
        private System.Windows.Forms.RadioButton code_radioButton;
        private System.Windows.Forms.Panel panel1;
    }
}
