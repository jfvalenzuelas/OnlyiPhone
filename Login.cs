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
    public partial class Login : Form
    {
    
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Identificación";

        }
        private bool mouseDown;
        private Point lastLocation;

    

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text.Trim().Length != 0 && passwordTextBox.Text.Trim().Length != 0)
            {
                string username = usernameTextBox.Text.Trim();
                string password = passwordTextBox.Text.Trim();

                User user = new User();

                user = Database.getUser(username);

                try
                {
                    if (Utils.Decrypt(user.Password) == password)
                    {
                        MessageBox.Show("Ingreso Exitoso, bienvenido "+user.Username, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main_Windows mr = new Main_Windows();
                        mr.send_username = user.Username;
                        mr.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Usuario incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Error al ingresar, rellene todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (usernameTextBox.Text.Trim().Length != 0 && passwordTextBox.Text.Trim().Length != 0)
                {
                    string username = usernameTextBox.Text.Trim();
                    string password = passwordTextBox.Text.Trim();

                    User user = new User();

                    user = Database.getUser(username);

                    try
                    {
                        if (Utils.Decrypt(user.Password) == password)
                        {
                            MessageBox.Show("Ingreso Exitoso, bienvenido " + user.Username, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main_Windows mr = new Main_Windows();
                            mr.send_username = user.Username;
                            mr.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Usuario incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                else
                {
                    MessageBox.Show("Error al ingresar, rellene todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
