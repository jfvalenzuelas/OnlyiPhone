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
    public partial class disableProducts: Form
    {
        public disableProducts()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Habilitar Productos";
        }
        private bool mouseDown;
        private Point lastLocation;
        string id;

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

        private void disableProducts_Load(object sender, EventArgs e)
        {
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listDisableProduct();
            gridView_disableproducts.DataSource = list;
            gridView_disableproducts.RowHeadersWidth = 18;
            gridView_disableproducts.Columns[1].Width = 170;
            gridView_disableproducts.Columns[10].Visible = false;
            gridView_disableproducts.Columns[2].HeaderText = "$ Venta";
            gridView_disableproducts.Columns[3].HeaderText = "$ Compra";
            gridView_disableproducts.Columns[4].HeaderText = "Stock";
            gridView_disableproducts.Columns[5].HeaderText = "Base";
            gridView_disableproducts.Columns[6].HeaderText = "Faltantes";
        }

        private void gridView_disableproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_add.Enabled = true;
            try
            {
                id = gridView_disableproducts.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch (Exception k)
            {
                Console.WriteLine(k);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea habilitar el producto?";
            string caption = "Confirmar habilitacion de producto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = Database.enableProduct(id);
                if (result > 0)
                {
                    try
                    {
                        MessageBox.Show("Producto habilitado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
