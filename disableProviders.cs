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
    public partial class disableProviders : Form
    {
   

        public disableProviders()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Habilitar Proveedores";
        }
        private bool mouseDown;
        private Point lastLocation;
        int id;

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void disableProviders_Load(object sender, EventArgs e)
        {
            List<Provider> list = new List<Provider>();
            list = Database.listDisableProviders();
            gridView_disableproviders.DataSource = list;
            gridView_disableproviders.RowHeadersWidth = 18;
            gridView_disableproviders.Columns[0].Visible = false;
            gridView_disableproviders.Columns[6].Visible = false;
        }

        private void gridView_disableproviders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_add.Enabled = true;
            try
            {
                id = Convert.ToInt32(gridView_disableproviders.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception k)
            {
                Console.WriteLine(k);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea habilitar el proveedor?";
            string caption = "Confirmar habilitacion de proveedor";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = Database.enableProvider(id);
                if (result > 0)
                {
                    try
                    {
                        MessageBox.Show("Proveedor habilitado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }
                }
            }
            button_add.Enabled = false;

        }
    }
}
