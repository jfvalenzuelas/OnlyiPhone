using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyIphone
{
    public partial class addUser : Form
    {

        public addUser()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private bool mouseDown;
        private Point lastLocation;
        bool validate_username;
        bool validate_pass;
        bool validate_pass1;

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(validate_username == false || validate_pass == false || validate_pass1 == false)
            {
                MessageBox.Show("Rellena todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User user = new User();
                user = Database.getUser(usernameTextBox.Text.Trim());

                if (user.Username == null)
                {
                    if (passwordTextBox.Text.Trim() == repeatpasswordTextBox.Text.Trim())
                    {
                        user.Username = usernameTextBox.Text.Trim();
                        user.Password = passwordTextBox.Text.Trim();
                        int result = Database.addUser(user);
                        if (result > 0)
                        {
                            try
                            {
                                MessageBox.Show("Usuario ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            catch (Exception l)
                            {
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            


        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim().Length == 0)
            {
                codecrossPictureBox.Visible = true;
                validate_username = false;
            }
            else
            {
                codecrossPictureBox.Visible = false;
                validate_username = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Trim().Length == 0)
            {
                namecrossPictureBox.Visible = true;
                validate_pass = false;
            }
            else
            {
                namecrossPictureBox.Visible = false;
                validate_pass = true;
            }
        }

        private void repeatpasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (repeatpasswordTextBox.Text.Trim().Length == 0)
            {
                salepricecrossPictureBox.Visible = true;
                validate_pass1 = false;
            }
            else
            {
                salepricecrossPictureBox.Visible = false;
                validate_pass1 = true;
            }
        }
    }
}
