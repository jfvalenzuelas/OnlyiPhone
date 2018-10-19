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
    public partial class viewDetailWorkOrder : Form
    {
        public int id;
        public viewDetailWorkOrder()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void button_add_Click(object sender, EventArgs e)
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

        private void viewDetailWorkOrder_Load(object sender, EventArgs e)
        {
            List<Detail_Work_Order> list = new List<Detail_Work_Order>();
            list = Database.getDetailsWorkOrders(id);
            dataGridView1.DataSource = list;
            dataGridView1.RowHeadersWidth = 18;
            dataGridView1.Columns[1].HeaderText = "Cantidad";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Precio Total";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Codigo Producto";
        }
    }
}
