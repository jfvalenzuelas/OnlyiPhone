using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;



namespace OnlyIphone
{
    public partial class products : UserControl
    {
        public bool resize = false;
        private static products _instance;

        
        public static products Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new products();
                return _instance;
            }
        }
        public products()
        {
            InitializeComponent();
        }
        string code;
        string name;
        string sale_price;
        string buyed_price;
        string stock;
        string desired;
        string provider;
        string category;
        string type;
        string active;

        private void addProductButton_Click(object sender, EventArgs e)
        {
            addProducts prd = new addProducts();
            prd.ShowDialog();
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("products");
            gridView_products.DataSource = list;

            int val = 0;
            int val_comp = 0;
            DataGridViewCell cell_aux = null;

            foreach (DataGridViewRow row in gridView_products.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine(cell.Value);
                    if (cell.ColumnIndex == 4)
                    {
                        cell_aux = cell;
                        val = Convert.ToInt32(cell_aux.Value);
                    }
                    else
                    {
                        if (cell.ColumnIndex == 5)
                        {
                            val_comp = Convert.ToInt32(cell.Value);
                            if (val <= (val_comp / 10))
                            {
                                cell_aux.Style.BackColor = Color.Red;
                                val = 0;
                                val_comp = 0;
                                cell_aux = null;

                            }
                        }
                    }
                }
            }
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            addType newtype = new addType();
            newtype.Show();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            addCategory windowAux = new addCategory();
            windowAux.Show();
        }

        private void products_Load(object sender, EventArgs e)
        {
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("products");
            gridView_products.DataSource = list;
            gridView_products.RowHeadersWidth = 18;
            gridView_products.Columns[1].Width = 170;
            gridView_products.Columns[10].Visible = false;
            gridView_products.Columns[2].HeaderText = "$ Venta";
            gridView_products.Columns[3].HeaderText = "$ Compra";
            gridView_products.Columns[4].HeaderText = "Stock";
            gridView_products.Columns[5].HeaderText = "Base";
            gridView_products.Columns[6].HeaderText = "Faltantes";

            int val = 0;
            int val_comp = 0;
            DataGridViewCell cell_aux = null;

            foreach (DataGridViewRow row in gridView_products.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine(cell.Value);
                    if (cell.ColumnIndex == 4)
                    {
                        cell_aux = cell;
                        val = Convert.ToInt32(cell_aux.Value);
                    }
                    else
                    {
                        if (cell.ColumnIndex == 5)
                        {
                            val_comp = Convert.ToInt32(cell.Value);
                            if (val <= (val_comp/10))
                            {
                                cell_aux.Style.BackColor = Color.Red;
                                val = 0;
                                val_comp = 0;
                                cell_aux = null;

                            }
                        }
                    }
                }
            }

        }

        private void textbox_search_KeyUp(object sender, KeyEventArgs e)
        {
            List<Product_Display> list = new List<Product_Display>();

            if (code_radioButton.Checked)
            {                       
                list = Database.findProduct(textbox_search.Text, "id","products");
                gridView_products.DataSource = list;

            }
            else if (name_radioButton.Checked)
            {                
                list = Database.findProduct(textbox_search.Text,"name","products");
                gridView_products.DataSource = list;
            }
            else
            {

            }
            
        }

        private void gridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_edit.Enabled = true;
            button_edit.BackColor = Color.FromArgb(60, 141, 188);
            button_disable.Enabled = true;
            button_disable.BackColor = Color.FromArgb(221, 75, 57);
            try
            {
                code = gridView_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                name = gridView_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                sale_price = gridView_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                buyed_price = gridView_products.Rows[e.RowIndex].Cells[3].Value.ToString();
                stock = gridView_products.Rows[e.RowIndex].Cells[4].Value.ToString();
                desired = gridView_products.Rows[e.RowIndex].Cells[5].Value.ToString();
                provider = gridView_products.Rows[e.RowIndex].Cells[7].Value.ToString();
                category = gridView_products.Rows[e.RowIndex].Cells[8].Value.ToString();
                type = gridView_products.Rows[e.RowIndex].Cells[9].Value.ToString();
                active = gridView_products.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch(Exception k)
            {
                Console.WriteLine(k);
            }
            
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            editProduct editproduct = new editProduct();
            editproduct.code = code;
            editproduct.name = name;
            editproduct.sale_price = sale_price;
            editproduct.buyed_price = buyed_price;
            editproduct.stock = stock;
            editproduct.desired = desired;
            editproduct.provider = provider;
            editproduct.category = category;
            editproduct.type = type;
            editproduct.active = active;
            editproduct.ShowDialog();
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("products");
            gridView_products.DataSource = list;

            int val = 0;
            int val_comp = 0;
            DataGridViewCell cell_aux = null;

            foreach (DataGridViewRow row in gridView_products.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine(cell.Value);
                    if (cell.ColumnIndex == 4)
                    {
                        cell_aux = cell;
                        val = Convert.ToInt32(cell_aux.Value);
                    }
                    else
                    {
                        if (cell.ColumnIndex == 5)
                        {
                            val_comp = Convert.ToInt32(cell.Value);
                            if (val <= (val_comp / 10))
                            {
                                cell_aux.Style.BackColor = Color.Red;
                                val = 0;
                                val_comp = 0;
                                cell_aux = null;

                            }
                        }
                    }
                }
            }
        }

        private void button_disable_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea deshabilitar el producto?";
            string caption = "Confirmar deshabilitacion de producto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = Database.disableProduct(code);
                if (result > 0)
                {
                    try
                    {
                        List<Product_Display> list = new List<Product_Display>();
                        list = Database.listProducts("products");
                        gridView_products.DataSource = list;
                        MessageBox.Show("Proveedor deshabilitado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int val = 0;
                        int val_comp = 0;
                        DataGridViewCell cell_aux = null;

                        foreach (DataGridViewRow row in gridView_products.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                Console.WriteLine(cell.Value);
                                if (cell.ColumnIndex == 4)
                                {
                                    cell_aux = cell;
                                    val = Convert.ToInt32(cell_aux.Value);
                                }
                                else
                                {
                                    if (cell.ColumnIndex == 5)
                                    {
                                        val_comp = Convert.ToInt32(cell.Value);
                                        if (val <= (val_comp / 10))
                                        {
                                            cell_aux.Style.BackColor = Color.Red;
                                            val = 0;
                                            val_comp = 0;
                                            cell_aux = null;

                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }
                }
            }
            button_disable.Enabled = false;
            button_disable.BackColor = Color.FromArgb(233, 139, 127);
            button_disable.ForeColor = Color.White;
            button_edit.Enabled = false;
            button_edit.BackColor = Color.FromArgb(129, 181,212);
            button_edit.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disableProducts disableproducts = new disableProducts();
            disableproducts.ShowDialog();
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("products");
            gridView_products.DataSource = list;

            int val = 0;
            int val_comp = 0;
            DataGridViewCell cell_aux = null;

            foreach (DataGridViewRow row in gridView_products.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine(cell.Value);
                    if (cell.ColumnIndex == 4)
                    {
                        cell_aux = cell;
                        val = Convert.ToInt32(cell_aux.Value);
                    }
                    else
                    {
                        if (cell.ColumnIndex == 5)
                        {
                            val_comp = Convert.ToInt32(cell.Value);
                            if (val <= (val_comp / 10))
                            {
                                cell_aux.Style.BackColor = Color.Red;
                                val = 0;
                                val_comp = 0;
                                cell_aux = null;

                            }
                        }
                    }
                }
            }
        }

        private void products_Paint(object sender, PaintEventArgs e)
        {
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("products");
            gridView_products.DataSource = list;

            int val = 0;
            int val_comp = 0;
            DataGridViewCell cell_aux = null;

            foreach (DataGridViewRow row in gridView_products.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Console.WriteLine(cell.Value);
                    if (cell.ColumnIndex == 4)
                    {
                        cell_aux = cell;
                        val = Convert.ToInt32(cell_aux.Value);
                    }
                    else
                    {
                        if (cell.ColumnIndex == 5)
                        {
                            val_comp = Convert.ToInt32(cell.Value);
                            if (val <= (val_comp / 10))
                            {
                                cell_aux.Style.BackColor = Color.Red;
                                val = 0;
                                val_comp = 0;
                                cell_aux = null;

                            }
                        }
                    }
                }
            }
        }

        private void code_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_getInventory_Click(object sender, EventArgs e)
        {
            getInventory new_window = new getInventory();
            new_window.Show();
        }

        private void products_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.label_title_list.Left = this.label_title_list.Left - 50;
                this.button_getInventory.Left = this.button_getInventory.Left - 50;
                this.gridView_products.Left = this.gridView_products.Left - 50;
                this.filterPanel.Left = this.filterPanel.Left - 50;
                this.buttonPanel.Left = this.buttonPanel.Left - 50;
                this.resize = false;
            }
            else
            {
                this.label_title_list.Left = this.label_title_list.Left + 50;
                this.button_getInventory.Left = this.button_getInventory.Left + 50;
                this.gridView_products.Left = this.gridView_products.Left + 50;
                this.filterPanel.Left = this.filterPanel.Left + 50;
                this.buttonPanel.Left = this.buttonPanel.Left + 50;
                this.resize = true;
            }
        }
    }
}
