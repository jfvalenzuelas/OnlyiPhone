namespace OnlyIphone
{
    partial class addUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUser));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.repeatpasswordTextBox = new System.Windows.Forms.TextBox();
            this.label_repeatpassword = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.salepricecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.namecrossPictureBox = new System.Windows.Forms.PictureBox();
            this.codecrossPictureBox = new System.Windows.Forms.PictureBox();
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
            this.headerPanel.Size = new System.Drawing.Size(353, 20);
            this.headerPanel.TabIndex = 29;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usernameTextBox.Location = new System.Drawing.Point(157, 53);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(160, 21);
            this.usernameTextBox.TabIndex = 31;
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_username.Location = new System.Drawing.Point(13, 53);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(130, 16);
            this.label_username.TabIndex = 30;
            this.label_username.Text = "Nombre de usuario";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passwordTextBox.Location = new System.Drawing.Point(157, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(160, 21);
            this.passwordTextBox.TabIndex = 33;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_password.Location = new System.Drawing.Point(13, 94);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(83, 16);
            this.label_password.TabIndex = 32;
            this.label_password.Text = "Contraseña";
            // 
            // repeatpasswordTextBox
            // 
            this.repeatpasswordTextBox.BackColor = System.Drawing.Color.White;
            this.repeatpasswordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatpasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.repeatpasswordTextBox.Location = new System.Drawing.Point(157, 132);
            this.repeatpasswordTextBox.Name = "repeatpasswordTextBox";
            this.repeatpasswordTextBox.PasswordChar = '*';
            this.repeatpasswordTextBox.Size = new System.Drawing.Size(160, 21);
            this.repeatpasswordTextBox.TabIndex = 35;
            this.repeatpasswordTextBox.Leave += new System.EventHandler(this.repeatpasswordTextBox_Leave);
            // 
            // label_repeatpassword
            // 
            this.label_repeatpassword.AutoSize = true;
            this.label_repeatpassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repeatpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_repeatpassword.Location = new System.Drawing.Point(13, 132);
            this.label_repeatpassword.Name = "label_repeatpassword";
            this.label_repeatpassword.Size = new System.Drawing.Size(128, 16);
            this.label_repeatpassword.TabIndex = 34;
            this.label_repeatpassword.Text = "Repite contraseña";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_cancel.Location = new System.Drawing.Point(157, 173);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 37;
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
            this.button_add.Location = new System.Drawing.Point(242, 173);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 36;
            this.button_add.Text = "Agregar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_title.Location = new System.Drawing.Point(12, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(150, 23);
            this.label_title.TabIndex = 41;
            this.label_title.Text = "Nuevo Usuario";
            // 
            // salepricecrossPictureBox
            // 
            this.salepricecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("salepricecrossPictureBox.Image")));
            this.salepricecrossPictureBox.Location = new System.Drawing.Point(323, 132);
            this.salepricecrossPictureBox.Name = "salepricecrossPictureBox";
            this.salepricecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.salepricecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salepricecrossPictureBox.TabIndex = 40;
            this.salepricecrossPictureBox.TabStop = false;
            this.salepricecrossPictureBox.Visible = false;
            // 
            // namecrossPictureBox
            // 
            this.namecrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("namecrossPictureBox.Image")));
            this.namecrossPictureBox.Location = new System.Drawing.Point(323, 91);
            this.namecrossPictureBox.Name = "namecrossPictureBox";
            this.namecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.namecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namecrossPictureBox.TabIndex = 39;
            this.namecrossPictureBox.TabStop = false;
            this.namecrossPictureBox.Visible = false;
            // 
            // codecrossPictureBox
            // 
            this.codecrossPictureBox.Image = global::OnlyIphone.Properties.Resources.typicons_2_0_7_delete_20_0_f56954_none;
            this.codecrossPictureBox.Location = new System.Drawing.Point(323, 53);
            this.codecrossPictureBox.Name = "codecrossPictureBox";
            this.codecrossPictureBox.Size = new System.Drawing.Size(20, 20);
            this.codecrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codecrossPictureBox.TabIndex = 38;
            this.codecrossPictureBox.TabStop = false;
            this.codecrossPictureBox.Visible = false;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(353, 216);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.salepricecrossPictureBox);
            this.Controls.Add(this.namecrossPictureBox);
            this.Controls.Add(this.codecrossPictureBox);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.repeatpasswordTextBox);
            this.Controls.Add(this.label_repeatpassword);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addUser";
            this.Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.salepricecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namecrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codecrossPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox repeatpasswordTextBox;
        private System.Windows.Forms.Label label_repeatpassword;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.PictureBox salepricecrossPictureBox;
        private System.Windows.Forms.PictureBox namecrossPictureBox;
        private System.Windows.Forms.PictureBox codecrossPictureBox;
        private System.Windows.Forms.Label label_title;
    }
}