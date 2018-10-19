namespace OnlyIphone
{
    partial class sale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_sales = new System.Windows.Forms.DataGridView();
            this.label_title_sales = new System.Windows.Forms.Label();
            this.dataGridView_works = new System.Windows.Forms.DataGridView();
            this.label_title_works = new System.Windows.Forms.Label();
            this.button_viewDetailOrder = new System.Windows.Forms.Button();
            this.button_deleteOrder = new System.Windows.Forms.Button();
            this.button_viewDetailSale = new System.Windows.Forms.Button();
            this.button_deleteSale = new System.Windows.Forms.Button();
            this.button_newWork = new System.Windows.Forms.Button();
            this.button_newSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_works)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_sales
            // 
            this.dataGridView_sales.AllowUserToAddRows = false;
            this.dataGridView_sales.AllowUserToDeleteRows = false;
            this.dataGridView_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_sales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sales.GridColor = System.Drawing.Color.White;
            this.dataGridView_sales.Location = new System.Drawing.Point(27, 55);
            this.dataGridView_sales.Name = "dataGridView_sales";
            this.dataGridView_sales.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.dataGridView_sales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_sales.Size = new System.Drawing.Size(663, 220);
            this.dataGridView_sales.TabIndex = 37;
            this.dataGridView_sales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sales_CellClick);
            // 
            // label_title_sales
            // 
            this.label_title_sales.AutoSize = true;
            this.label_title_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_sales.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_sales.Location = new System.Drawing.Point(30, 27);
            this.label_title_sales.Name = "label_title_sales";
            this.label_title_sales.Size = new System.Drawing.Size(221, 25);
            this.label_title_sales.TabIndex = 39;
            this.label_title_sales.Text = "Listado de Ventas";
            // 
            // dataGridView_works
            // 
            this.dataGridView_works.AllowUserToAddRows = false;
            this.dataGridView_works.AllowUserToDeleteRows = false;
            this.dataGridView_works.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_works.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_works.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_works.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_works.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_works.GridColor = System.Drawing.Color.White;
            this.dataGridView_works.Location = new System.Drawing.Point(27, 327);
            this.dataGridView_works.Name = "dataGridView_works";
            this.dataGridView_works.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.dataGridView_works.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_works.Size = new System.Drawing.Size(663, 220);
            this.dataGridView_works.TabIndex = 41;
            this.dataGridView_works.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_works_CellClick);
            // 
            // label_title_works
            // 
            this.label_title_works.AutoSize = true;
            this.label_title_works.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_works.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_works.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_works.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_works.Location = new System.Drawing.Point(22, 294);
            this.label_title_works.Name = "label_title_works";
            this.label_title_works.Size = new System.Drawing.Size(241, 25);
            this.label_title_works.TabIndex = 43;
            this.label_title_works.Text = "Listado de Trabajos";
            // 
            // button_viewDetailOrder
            // 
            this.button_viewDetailOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_viewDetailOrder.Enabled = false;
            this.button_viewDetailOrder.FlatAppearance.BorderSize = 0;
            this.button_viewDetailOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewDetailOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewDetailOrder.ForeColor = System.Drawing.Color.White;
            this.button_viewDetailOrder.Image = global::OnlyIphone.Properties.Resources.foundation_icon_fonts_2015_02_16_page_search_25_0_f1f1f1_none1;
            this.button_viewDetailOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_viewDetailOrder.Location = new System.Drawing.Point(696, 419);
            this.button_viewDetailOrder.Name = "button_viewDetailOrder";
            this.button_viewDetailOrder.Size = new System.Drawing.Size(140, 40);
            this.button_viewDetailOrder.TabIndex = 48;
            this.button_viewDetailOrder.Text = "Ver Detalle";
            this.button_viewDetailOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_viewDetailOrder.UseVisualStyleBackColor = false;
            this.button_viewDetailOrder.Click += new System.EventHandler(this.button_viewDetailOrder_Click);
            // 
            // button_deleteOrder
            // 
            this.button_deleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button_deleteOrder.FlatAppearance.BorderSize = 0;
            this.button_deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteOrder.ForeColor = System.Drawing.Color.White;
            this.button_deleteOrder.Image = global::OnlyIphone.Properties.Resources.ionicons_2_0_1_android_delete_25_0_f1f1f1_none1;
            this.button_deleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteOrder.Location = new System.Drawing.Point(696, 373);
            this.button_deleteOrder.Name = "button_deleteOrder";
            this.button_deleteOrder.Size = new System.Drawing.Size(140, 40);
            this.button_deleteOrder.TabIndex = 47;
            this.button_deleteOrder.Text = "Anular Orden";
            this.button_deleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deleteOrder.UseVisualStyleBackColor = false;
            this.button_deleteOrder.Click += new System.EventHandler(this.button_deleteOrder_Click);
            // 
            // button_viewDetailSale
            // 
            this.button_viewDetailSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_viewDetailSale.Enabled = false;
            this.button_viewDetailSale.FlatAppearance.BorderSize = 0;
            this.button_viewDetailSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewDetailSale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewDetailSale.ForeColor = System.Drawing.Color.White;
            this.button_viewDetailSale.Image = global::OnlyIphone.Properties.Resources.foundation_icon_fonts_2015_02_16_page_search_25_0_f1f1f1_none;
            this.button_viewDetailSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_viewDetailSale.Location = new System.Drawing.Point(696, 147);
            this.button_viewDetailSale.Name = "button_viewDetailSale";
            this.button_viewDetailSale.Size = new System.Drawing.Size(140, 40);
            this.button_viewDetailSale.TabIndex = 46;
            this.button_viewDetailSale.Text = "Ver Detalle";
            this.button_viewDetailSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_viewDetailSale.UseVisualStyleBackColor = false;
            this.button_viewDetailSale.Click += new System.EventHandler(this.button_viewDetailSale_Click);
            // 
            // button_deleteSale
            // 
            this.button_deleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.button_deleteSale.FlatAppearance.BorderSize = 0;
            this.button_deleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteSale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteSale.ForeColor = System.Drawing.Color.White;
            this.button_deleteSale.Image = global::OnlyIphone.Properties.Resources.ionicons_2_0_1_android_delete_25_0_f1f1f1_none;
            this.button_deleteSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteSale.Location = new System.Drawing.Point(696, 101);
            this.button_deleteSale.Name = "button_deleteSale";
            this.button_deleteSale.Size = new System.Drawing.Size(140, 40);
            this.button_deleteSale.TabIndex = 44;
            this.button_deleteSale.Text = "Anular Venta";
            this.button_deleteSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deleteSale.UseVisualStyleBackColor = false;
            this.button_deleteSale.Click += new System.EventHandler(this.button_deleteSale_Click);
            // 
            // button_newWork
            // 
            this.button_newWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button_newWork.FlatAppearance.BorderSize = 0;
            this.button_newWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newWork.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newWork.ForeColor = System.Drawing.Color.White;
            this.button_newWork.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_addnew_25_0_f1f1f1_none;
            this.button_newWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newWork.Location = new System.Drawing.Point(696, 327);
            this.button_newWork.Name = "button_newWork";
            this.button_newWork.Size = new System.Drawing.Size(140, 40);
            this.button_newWork.TabIndex = 40;
            this.button_newWork.Text = "Nuevo Trabajo";
            this.button_newWork.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_newWork.UseVisualStyleBackColor = false;
            this.button_newWork.Click += new System.EventHandler(this.button_newWork_Click);
            // 
            // button_newSale
            // 
            this.button_newSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.button_newSale.FlatAppearance.BorderSize = 0;
            this.button_newSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newSale.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newSale.ForeColor = System.Drawing.Color.White;
            this.button_newSale.Image = global::OnlyIphone.Properties.Resources.ligature_symbols_2_11_0_add_25_0_f1f1f1_none;
            this.button_newSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newSale.Location = new System.Drawing.Point(696, 55);
            this.button_newSale.Name = "button_newSale";
            this.button_newSale.Size = new System.Drawing.Size(140, 40);
            this.button_newSale.TabIndex = 36;
            this.button_newSale.Text = "Nueva Venta";
            this.button_newSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_newSale.UseVisualStyleBackColor = false;
            this.button_newSale.Click += new System.EventHandler(this.button_newSale_Click);
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.button_viewDetailOrder);
            this.Controls.Add(this.button_deleteOrder);
            this.Controls.Add(this.button_viewDetailSale);
            this.Controls.Add(this.button_deleteSale);
            this.Controls.Add(this.label_title_works);
            this.Controls.Add(this.dataGridView_works);
            this.Controls.Add(this.button_newWork);
            this.Controls.Add(this.label_title_sales);
            this.Controls.Add(this.dataGridView_sales);
            this.Controls.Add(this.button_newSale);
            this.Name = "sale";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.sale_Load);
            this.Resize += new System.EventHandler(this.sale_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_works)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_newSale;
        private System.Windows.Forms.DataGridView dataGridView_sales;
        private System.Windows.Forms.Label label_title_sales;
        private System.Windows.Forms.Button button_newWork;
        private System.Windows.Forms.DataGridView dataGridView_works;
        private System.Windows.Forms.Label label_title_works;
        private System.Windows.Forms.Button button_deleteSale;
        private System.Windows.Forms.Button button_viewDetailSale;
        private System.Windows.Forms.Button button_deleteOrder;
        private System.Windows.Forms.Button button_viewDetailOrder;
    }
}
