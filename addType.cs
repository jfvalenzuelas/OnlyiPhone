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
    public partial class addType : Form
    {
        public addType()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        bool validate_name;
        private bool mouseDown;
        private Point lastLocation;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            Type type = new Type();

            if (validate_name == false)
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                type.Name = Utils.FirstLetterToUpeer(nameTextBox.Text.Trim());
                int result = Database.addType(type);
                if (result > 0)
                {
                    try
                    {
                        MessageBox.Show("Tipo ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    catch (Exception l)
                    {
                    }

                }
                else
                {
                    MessageBox.Show("Error al ingresar el tipo, revise la información", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

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

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
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
