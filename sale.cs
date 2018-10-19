using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyIphone
{
    public partial class sale : UserControl
    {
        public string username;
        public bool resize = false;
        private static sale _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static sale Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sale();
                return _instance;
            }
        }
        public sale()
        {
            InitializeComponent();
        }
        DateTime date;
        int id;
        int total_price;
        int id1;
        int total_price1;
       


        private void sale_Load(object sender, EventArgs e)
        {
            date = DateTime.Now;
            List<Sales_Display> list = new List<Sales_Display>();
            list = Database.listSales(date.Date);
            dataGridView_sales.DataSource = list;
            dataGridView_sales.RowHeadersWidth = 18;
            dataGridView_sales.Columns[0].Visible = false;
            dataGridView_sales.Columns[1].HeaderText = "Fecha venta";
            dataGridView_sales.Columns[1].Width = 80;
            dataGridView_sales.Columns[2].HeaderText = "Total";
            dataGridView_sales.Columns[3].HeaderText = "Método de pago";
            dataGridView_sales.Columns[4].Visible = false;
            dataGridView_sales.Columns[5].HeaderText = "Rut Cliente";
            dataGridView_sales.Columns[6].HeaderText = "Vendedor";

            List<Work_Order_Display> list1 = new List<Work_Order_Display>();
            list1 = Database.listWorkOrders(date.Date);
            dataGridView_works.DataSource = list1;
            dataGridView_works.RowHeadersWidth = 18;
            dataGridView_works.Columns[0].Visible = false;
            dataGridView_works.Columns[1].HeaderText = "Fecha Orden";
            dataGridView_works.Columns[1].Width = 80;
            dataGridView_works.Columns[2].HeaderText = "Total";
            dataGridView_works.Columns[3].HeaderText = "Método de pago";
            dataGridView_works.Columns[4].Visible = false;
            dataGridView_works.Columns[5].Visible = false;
            dataGridView_works.Columns[6].HeaderText = "Rut Cliente";
            dataGridView_works.Columns[7].HeaderText = "Vendedor";



        }


        private void button_newSale_Click(object sender, EventArgs e)
        {
            addSale addsale = new addSale();
            addsale.username = username;
            addsale.ShowDialog();
            List<Sales_Display> list = new List<Sales_Display>();
            list = Database.listSales(date.Date);
            dataGridView_sales.DataSource = list;

        }
        private void button_deleteSale_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea anular la venta?";
            string caption = "Confirmar anulación de venta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //Actualiza la caja
                Cashboxs cashbox = new Cashboxs();
                cashbox.income = total_price;
                cashbox.date = date.Date;
                int result_updateCashbox = Database.updateCashBox1(cashbox, "income");
                if (result_updateCashbox > 0)
                {
                    Console.WriteLine("Caja actualizada");
                }
                //Actualiza el stock de productos antes de borrar el detalle
                List<Detail> detail = new List<Detail>();
                detail = Database.getDetails(id);
                foreach (Detail d in detail)
                {
                    Database.updateAddStockProduct(d.product, d.quantity);

                }




                //Borra la venta de sale y el detalle
                int result = Database.deleteSale(id);
                if (result > 0)
                {
                    List<Sales_Display> list = new List<Sales_Display>();
                    list = Database.listSales(date.Date);
                    dataGridView_sales.DataSource = list;
                    MessageBox.Show("Venta anulada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        private void button_viewDetailSale_Click(object sender, EventArgs e)
        {
            viewDetail viewdetail = new viewDetail();
            viewdetail.id = id;
            viewdetail.Show();
        }
        private void button_newWork_Click(object sender, EventArgs e)
        {
            addWorkOrder workorder = new addWorkOrder();
            workorder.username = username;
            workorder.ShowDialog();
            List<Work_Order_Display> list1 = new List<Work_Order_Display>();
            list1 = Database.listWorkOrders(date.Date);
            dataGridView_works.DataSource = list1;
        }
        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea anular la orden?";
            string caption = "Confirmar anulación de orden";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                //Actualiza la caja
                Cashboxs cashbox = new Cashboxs();
                cashbox.income = total_price1;
                cashbox.date = date.Date;
                int result_updateCashbox = Database.updateCashBox1(cashbox, "income");
                if (result_updateCashbox > 0)
                {
                    Console.WriteLine("Caja actualizada");
                }
                //Actualiza el stock de productos antes de borrar el detalle
                List<Detail_Work_Order> detail = new List<Detail_Work_Order>();
                detail = Database.getDetailsWorkOrders(id1);
                foreach (Detail_Work_Order d in detail)
                {
                    Database.updateAddStockProduct(d.product, d.quantity);

                }




                //Borra la orden de trabajo
                int result = Database.deleteWorkOrder(id1);
                if (result > 0)
                {
                    List<Work_Order_Display> list1 = new List<Work_Order_Display>();
                    list1 = Database.listWorkOrders(date.Date);
                    dataGridView_works.DataSource = list1;
                    MessageBox.Show("Orden anulada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

        }


        private void dataGridView_sales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_viewDetailSale.Enabled = true;
            try
            {
                id = Convert.ToInt32(dataGridView_sales.Rows[e.RowIndex].Cells[0].Value);
                total_price = Convert.ToInt32(dataGridView_sales.Rows[e.RowIndex].Cells[2].Value);


            }
            catch (Exception k)
            {

            }
        }
        private void dataGridView_works_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_viewDetailOrder.Enabled = true;
            try
            {
                id1 = Convert.ToInt32(dataGridView_works.Rows[e.RowIndex].Cells[0].Value);
                total_price1 = Convert.ToInt32(dataGridView_works.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception k)
            {

            }
            
            
        
        }

        private void button_viewDetailOrder_Click(object sender, EventArgs e)
        {
            viewDetailWorkOrder detail = new viewDetailWorkOrder();
            detail.id = id1;
            detail.Show();
        }

        private void sale_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.label_title_sales.Left = this.label_title_sales.Left - 50;
                this.label_title_works.Left = this.label_title_works.Left - 50;
                this.dataGridView_sales.Left = this.dataGridView_sales.Left - 50;
                this.dataGridView_works.Left = this.dataGridView_works.Left - 50;
                this.button_deleteOrder.Left = this.button_deleteOrder.Left - 50;
                this.button_deleteSale.Left = this.button_deleteSale.Left - 50;
                this.button_newSale.Left = this.button_newSale.Left - 50;
                this.button_newWork.Left = this.button_newWork.Left - 50;
                this.button_viewDetailOrder.Left = this.button_viewDetailOrder.Left - 50;
                this.button_viewDetailSale.Left = this.button_viewDetailSale.Left - 50;
                this.resize = false;
            }
            else
            {
                this.label_title_sales.Left = this.label_title_sales.Left + 50;
                this.label_title_works.Left = this.label_title_works.Left + 50;
                this.dataGridView_sales.Left = this.dataGridView_sales.Left + 50;
                this.dataGridView_works.Left = this.dataGridView_works.Left + 50;
                this.button_deleteOrder.Left = this.button_deleteOrder.Left + 50;
                this.button_deleteSale.Left = this.button_deleteSale.Left + 50;
                this.button_newSale.Left = this.button_newSale.Left + 50;
                this.button_newWork.Left = this.button_newWork.Left + 50;
                this.button_viewDetailOrder.Left = this.button_viewDetailOrder.Left + 50;
                this.button_viewDetailSale.Left = this.button_viewDetailSale.Left + 50;
                this.resize = true;
            }
        }
    }
}
