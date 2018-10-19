using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlyIphone
{
    public partial class addProviders : Form
    {
        public addProviders()
        {
            InitializeComponent();
            this.CenterToScreen();
            phoneTextBox.MaxLength = 9;
        }
        bool validate_name = false;
        bool validate_phone = false;
        bool validate_email = false;
        bool validate_address = false;
        bool validate_city = false;

        private bool mouseDown;
        private Point lastLocation;

       
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                namecrossPictureBox.Visible = true;
                validate_name = false;
            }
            else
            {
                namecrossPictureBox.Visible = false;

                validate_name = true;
            }
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneTextBox.Text.Trim().Length == 0)
            {
                phonecrossPictureBox.Visible = true;
                validate_phone = false;
            }
            else
            {
                phonecrossPictureBox.Visible = false;

                validate_phone = true;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(e);
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Trim().Length == 0)
            {
                emailcrossPictureBox.Visible = true;
                validate_email = false;
            }
            else if (Utils.ComprobarFormatoEmail(emailTextBox.Text.Trim()) == false)
            {
                emailcrossPictureBox.Visible = true;
                validate_email = false;
            }
            else
            {
                emailcrossPictureBox.Visible = false;

                validate_email = true;
            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (addressTextBox.Text.Trim().Length == 0)
            {
                addresscrossPictureBox.Visible = true;
                validate_address = false;
            }
            else
            {
                addresscrossPictureBox.Visible = false;

                validate_address = true;
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            if (cityTextBox.Text.Trim().Length == 0)
            {
                citycrossPictureBox.Visible = true;
                validate_city = false;
            }
            else
            {
                citycrossPictureBox.Visible = false;

                validate_city = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Provider prv = new Provider();

            if (validate_name == false || validate_phone == false || validate_email == false || validate_address == false || validate_email == false)
            {
                MessageBox.Show("Datos incorrectos o incompletos");
            }
            else
            {
                prv.Name = Utils.FirstLetterToUpeer(nameTextBox.Text.Trim());
                prv.Phone = Int32.Parse(phoneTextBox.Text.Trim());
                prv.Email = emailTextBox.Text.Trim();
                prv.Address = Utils.FirstLetterToUpeer(addressTextBox.Text.Trim());
                prv.City = Utils.FirstLetterToUpeer(cityTextBox.Text.Trim());

                int result = Database.addProvider(prv);
                if (result > 0)
                {
                    try
                    {
                        
                        MessageBox.Show("Proveedor ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
              
                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }

                }
                else
                {
                    MessageBox.Show("Error al ingresar el proveedor, revise la información", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
