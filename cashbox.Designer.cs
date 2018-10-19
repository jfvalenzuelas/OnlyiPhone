namespace OnlyIphone
{
    partial class cashbox
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
            this.totalcountLabel = new System.Windows.Forms.Label();
            this.label_title_cashbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalOutcomeLabel = new System.Windows.Forms.Label();
            this.outcome_input_group = new System.Windows.Forms.GroupBox();
            this.button_addOutcome = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.income_panel = new System.Windows.Forms.Panel();
            this.outcome_panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.outcome_input_group.SuspendLayout();
            this.income_panel.SuspendLayout();
            this.outcome_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalcountLabel
            // 
            this.totalcountLabel.AutoSize = true;
            this.totalcountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.totalcountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalcountLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalcountLabel.Location = new System.Drawing.Point(85, 2);
            this.totalcountLabel.Name = "totalcountLabel";
            this.totalcountLabel.Size = new System.Drawing.Size(147, 78);
            this.totalcountLabel.TabIndex = 38;
            this.totalcountLabel.Text = "$ 0";
            // 
            // label_title_cashbox
            // 
            this.label_title_cashbox.AutoSize = true;
            this.label_title_cashbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label_title_cashbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title_cashbox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_cashbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_title_cashbox.Location = new System.Drawing.Point(37, 23);
            this.label_title_cashbox.Name = "label_title_cashbox";
            this.label_title_cashbox.Size = new System.Drawing.Size(63, 25);
            this.label_title_cashbox.TabIndex = 39;
            this.label_title_cashbox.Text = "Caja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ingresos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Egresos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalOutcomeLabel
            // 
            this.totalOutcomeLabel.AutoSize = true;
            this.totalOutcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.totalOutcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalOutcomeLabel.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutcomeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalOutcomeLabel.Location = new System.Drawing.Point(85, 3);
            this.totalOutcomeLabel.Name = "totalOutcomeLabel";
            this.totalOutcomeLabel.Size = new System.Drawing.Size(147, 78);
            this.totalOutcomeLabel.TabIndex = 46;
            this.totalOutcomeLabel.Text = "$ 0";
            // 
            // outcome_input_group
            // 
            this.outcome_input_group.Controls.Add(this.button_addOutcome);
            this.outcome_input_group.Controls.Add(this.textBox_description);
            this.outcome_input_group.Controls.Add(this.label_value);
            this.outcome_input_group.Controls.Add(this.label_description);
            this.outcome_input_group.Controls.Add(this.textBox_value);
            this.outcome_input_group.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcome_input_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.outcome_input_group.Location = new System.Drawing.Point(44, 331);
            this.outcome_input_group.Name = "outcome_input_group";
            this.outcome_input_group.Size = new System.Drawing.Size(345, 221);
            this.outcome_input_group.TabIndex = 47;
            this.outcome_input_group.TabStop = false;
            this.outcome_input_group.Text = "Egreso";
            // 
            // button_addOutcome
            // 
            this.button_addOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button_addOutcome.FlatAppearance.BorderSize = 0;
            this.button_addOutcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOutcome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addOutcome.ForeColor = System.Drawing.Color.White;
            this.button_addOutcome.Location = new System.Drawing.Point(243, 182);
            this.button_addOutcome.Name = "button_addOutcome";
            this.button_addOutcome.Size = new System.Drawing.Size(84, 23);
            this.button_addOutcome.TabIndex = 4;
            this.button_addOutcome.Text = "Ingresar";
            this.button_addOutcome.UseVisualStyleBackColor = false;
            this.button_addOutcome.Click += new System.EventHandler(this.button_addOutcome_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox_description.Location = new System.Drawing.Point(102, 62);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(225, 102);
            this.textBox_description.TabIndex = 3;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_value.Location = new System.Drawing.Point(6, 25);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(40, 16);
            this.label_value.TabIndex = 2;
            this.label_value.Text = "Valor";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(6, 62);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(89, 16);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Observación";
            // 
            // textBox_value
            // 
            this.textBox_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_value.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox_value.Location = new System.Drawing.Point(102, 27);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(225, 14);
            this.textBox_value.TabIndex = 0;
            this.textBox_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_value_KeyPress);
            // 
            // income_panel
            // 
            this.income_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.income_panel.Controls.Add(this.panel3);
            this.income_panel.Controls.Add(this.totalcountLabel);
            this.income_panel.Controls.Add(this.label1);
            this.income_panel.Location = new System.Drawing.Point(45, 65);
            this.income_panel.Name = "income_panel";
            this.income_panel.Size = new System.Drawing.Size(765, 116);
            this.income_panel.TabIndex = 48;
            // 
            // outcome_panel
            // 
            this.outcome_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.outcome_panel.Controls.Add(this.panel4);
            this.outcome_panel.Controls.Add(this.totalOutcomeLabel);
            this.outcome_panel.Controls.Add(this.label2);
            this.outcome_panel.Location = new System.Drawing.Point(45, 196);
            this.outcome_panel.Name = "outcome_panel";
            this.outcome_panel.Size = new System.Drawing.Size(765, 116);
            this.outcome_panel.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_long_arrow_down_100_0_f1f1f1_none;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(1, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(99, 103);
            this.panel4.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::OnlyIphone.Properties.Resources.font_awesome_4_7_0_long_arrow_up_100_0_f1f1f1_none;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(1, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 103);
            this.panel3.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::OnlyIphone.Properties.Resources.cashbox__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(640, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 43;
            this.button1.Text = "Iniciar Caja";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.outcome_panel);
            this.Controls.Add(this.income_panel);
            this.Controls.Add(this.outcome_input_group);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_title_cashbox);
            this.Name = "cashbox";
            this.Size = new System.Drawing.Size(865, 570);
            this.Load += new System.EventHandler(this.cashbox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cashbox_Paint);
            this.Resize += new System.EventHandler(this.cashbox_Resize);
            this.outcome_input_group.ResumeLayout(false);
            this.outcome_input_group.PerformLayout();
            this.income_panel.ResumeLayout(false);
            this.income_panel.PerformLayout();
            this.outcome_panel.ResumeLayout(false);
            this.outcome_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalcountLabel;
        private System.Windows.Forms.Label label_title_cashbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalOutcomeLabel;
        private System.Windows.Forms.GroupBox outcome_input_group;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Button button_addOutcome;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Panel income_panel;
        private System.Windows.Forms.Panel outcome_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
