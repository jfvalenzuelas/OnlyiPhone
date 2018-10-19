namespace OnlyIphone
{
    partial class users
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
            this.dayNameLabel = new System.Windows.Forms.Label();
            this.gridView_users = new System.Windows.Forms.DataGridView();
            this.oldpass_TextBox = new System.Windows.Forms.TextBox();
            this.old_pass = new System.Windows.Forms.Label();
            this.newpass_TextBox = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.Label();
            this.newpass_TextBox1 = new System.Windows.Forms.TextBox();
            this.new_pass1 = new System.Windows.Forms.Label();
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.changepass = new System.Windows.Forms.GroupBox();
            this.button_newUser = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_users)).BeginInit();
            this.changepass.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayNameLabel
            // 
            this.dayNameLabel.AutoSize = true;
            this.dayNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dayNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dayNameLabel.Location = new System.Drawing.Point(30, 40);
            this.dayNameLabel.Name = "dayNameLabel";
            this.dayNameLabel.Size = new System.Drawing.Size(103, 23);
            this.dayNameLabel.TabIndex = 35;
            this.dayNameLabel.Text = "Usuarios";
            // 
            // gridView_users
            // 
            this.gridView_users.AllowUserToAddRows = false;
            this.gridView_users.AllowUserToDeleteRows = false;
            this.gridView_users.AllowUserToOrderColumns = true;
            this.gridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_users.BackgroundColor = System.Drawing.Color.White;
            this.gridView_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView_users.GridColor = System.Drawing.Color.White;
            this.gridView_users.Location = new System.Drawing.Point(34, 81);
            this.gridView_users.Name = "gridView_users";
            this.gridView_users.ReadOnly = true;
            this.gridView_users.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.gridView_users.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView_users.Size = new System.Drawing.Size(217, 260);
            this.gridView_users.TabIndex = 36;
            this.gridView_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_providers_CellClick);
            // 
            // oldpass_TextBox
            // 
            this.oldpass_TextBox.BackColor = System.Drawing.Color.White;
            this.oldpass_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldpass_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.oldpass_TextBox.Location = new System.Drawing.Point(191, 28);
            this.oldpass_TextBox.Name = "oldpass_TextBox";
            this.oldpass_TextBox.PasswordChar = '*';
            this.oldpass_TextBox.Size = new System.Drawing.Size(162, 21);
            this.oldpass_TextBox.TabIndex = 38;
            // 
            // old_pass
            // 
            this.old_pass.AutoSize = true;
            this.old_pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_pass.Location = new System.Drawing.Point(10, 30);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(138, 16);
            this.old_pass.TabIndex = 37;
            this.old_pass.Text = "Contraseña Antigua";
            // 
            // newpass_TextBox
            // 
            this.newpass_TextBox.BackColor = System.Drawing.Color.White;
            this.newpass_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpass_TextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.newpass_TextBox.Location = new System.Drawing.Point(191, 58);
            this.newpass_TextBox.Name = "newpass_TextBox";
            this.newpass_TextBox.PasswordChar = '*';
            this.newpass_TextBox.Size = new System.Drawing.Size(162, 21);
            this.newpass_TextBox.TabIndex = 40;
            // 
            // new_pass
            // 
            this.new_pass.AutoSize = true;
            this.new_pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass.Location = new System.Drawing.Point(10, 60);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(129, 16);
            this.new_pass.TabIndex = 39;
            this.new_pass.Text = "Contraseña Nueva";
            // 
            // newpass_TextBox1
            // 
            this.newpass_TextBox1.BackColor = System.Drawing.Color.White;
            this.newpass_TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpass_TextBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.newpass_TextBox1.Location = new System.Drawing.Point(191, 88);
            this.newpass_TextBox1.Name = "newpass_TextBox1";
            this.newpass_TextBox1.PasswordChar = '*';
            this.newpass_TextBox1.Size = new System.Drawing.Size(162, 21);
            this.newpass_TextBox1.TabIndex = 42;
            // 
            // new_pass1
            // 
            this.new_pass1.AutoSize = true;
            this.new_pass1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass1.Location = new System.Drawing.Point(10, 90);
            this.new_pass1.Name = "new_pass1";
            this.new_pass1.Size = new System.Drawing.Size(175, 16);
            this.new_pass1.TabIndex = 41;
            this.new_pass1.Text = "Repite Contraseña Nueva";
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.accept_button.FlatAppearance.BorderSize = 0;
            this.accept_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.ForeColor = System.Drawing.Color.White;
            this.accept_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.accept_button.Location = new System.Drawing.Point(246, 124);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(107, 32);
            this.accept_button.TabIndex = 43;
            this.accept_button.Text = "Aceptar";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.Location = new System.Drawing.Point(133, 124);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(107, 32);
            this.cancel_button.TabIndex = 44;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // changepass
            // 
            this.changepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.changepass.Controls.Add(this.old_pass);
            this.changepass.Controls.Add(this.accept_button);
            this.changepass.Controls.Add(this.cancel_button);
            this.changepass.Controls.Add(this.new_pass);
            this.changepass.Controls.Add(this.new_pass1);
            this.changepass.Controls.Add(this.newpass_TextBox1);
            this.changepass.Controls.Add(this.oldpass_TextBox);
            this.changepass.Controls.Add(this.newpass_TextBox);
            this.changepass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.changepass.Location = new System.Drawing.Point(301, 81);
            this.changepass.Name = "changepass";
            this.changepass.Size = new System.Drawing.Size(365, 170);
            this.changepass.TabIndex = 45;
            this.changepass.TabStop = false;
            this.changepass.Text = "Cambiar Contraseña";
            this.changepass.Visible = false;
            // 
            // button_newUser
            // 
            this.button_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_newUser.Enabled = false;
            this.button_newUser.FlatAppearance.BorderSize = 0;
            this.button_newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newUser.ForeColor = System.Drawing.Color.White;
            this.button_newUser.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_user_plus_25_0_f1f1f1_none;
            this.button_newUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_newUser.Location = new System.Drawing.Point(34, 421);
            this.button_newUser.Name = "button_newUser";
            this.button_newUser.Size = new System.Drawing.Size(66, 68);
            this.button_newUser.TabIndex = 46;
            this.button_newUser.Text = "Nuevo Usuario";
            this.button_newUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_newUser.UseVisualStyleBackColor = false;
            this.button_newUser.Click += new System.EventHandler(this.button_newUser_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button_edit.Enabled = false;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Image = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_pencil_25_0_f1f1f1_none;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_edit.Location = new System.Drawing.Point(34, 356);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(217, 48);
            this.button_edit.TabIndex = 34;
            this.button_edit.Text = "Cambiar Contraseña";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.button_newUser);
            this.Controls.Add(this.changepass);
            this.Controls.Add(this.gridView_users);
            this.Controls.Add(this.dayNameLabel);
            this.Controls.Add(this.button_edit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "users";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.users_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.users_Paint);
            this.Leave += new System.EventHandler(this.users_Leave);
            this.Resize += new System.EventHandler(this.users_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_users)).EndInit();
            this.changepass.ResumeLayout(false);
            this.changepass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.DataGridView gridView_users;
        private System.Windows.Forms.TextBox oldpass_TextBox;
        private System.Windows.Forms.Label old_pass;
        private System.Windows.Forms.TextBox newpass_TextBox;
        private System.Windows.Forms.Label new_pass;
        private System.Windows.Forms.TextBox newpass_TextBox1;
        private System.Windows.Forms.Label new_pass1;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.GroupBox changepass;
        private System.Windows.Forms.Button button_newUser;
    }
}
