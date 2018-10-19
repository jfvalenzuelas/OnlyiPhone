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
    public partial class addProducts : Form
    {
        public addProducts()
        {
            InitializeComponent();
            this.CenterToScreen();

            this.Text = "Agregar Producto";            
            typeComboBox.DataSource = load_type();
            typeComboBox.DisplayMember = "name";
            typeComboBox.ValueMember = "id";



            categoryComboBox.DataSource = load_category();
            categoryComboBox.DisplayMember = "name";
            categoryComboBox.ValueMember = "id";

            providerComboBox.DataSource = load_provider();
            providerComboBox.DisplayMember = "name";
            providerComboBox.ValueMember = "id";
        }
        private bool mouseDown;
        private Point lastLocation;
        bool validate_code = false;
        bool validate_name = false;
        bool validate_saleprice = false;
        bool validate_buyedprice = false;
        bool validate_stock = false;
        bool validate_desired = false;
        bool validate_provider = false;
        bool validate_type = false;
        bool validate_category = false;

        private DataTable load_type()
        {
            DataTable dt = new DataTable();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id, name FROM type"), Connection.getConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(_comando);
            adap.Fill(dt);

            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["name"] = "Seleccione Item";

            dt.Rows.InsertAt(row, 0);

            return dt;
        }

        private DataTable load_provider()
        {
            int active = 1;
            DataTable dt = new DataTable();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id, name FROM provider WHERE active={0}",active), Connection.getConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(_comando);
            adap.Fill(dt);
            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["name"] = "Seleccione Item";

            dt.Rows.InsertAt(row, 0);
            return dt;
        }

        private DataTable load_category()
        {
            DataTable dt = new DataTable();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id, name FROM category"), Connection.getConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(_comando);
            adap.Fill(dt);
            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["name"] = "Seleccione Item";

            dt.Rows.InsertAt(row, 0);
            return dt;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void codeTextBox_Leave(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Trim().Length == 0)
            {
                codecrossPictureBox.Visible = true;
                validate_code = false;
            }
            else
            {
                codecrossPictureBox.Visible = false;
                validate_code = true;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if(nameTextBox.Text.Trim().Length == 0)
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

        private void salepriceTextBox_Leave(object sender, EventArgs e)
        {
            if (salepriceTextBox.Text.Trim().Length == 0)
            {
                salepricecrossPictureBox.Visible = true;
                validate_saleprice = false;
            }
            else
            {
                salepricecrossPictureBox.Visible = false;
                validate_saleprice = true;
            }

        }

        private void salepriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(e);
        }

        private void buyedpriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(e);
        }

        private void buyedpriceTextBox_Leave(object sender, EventArgs e)
        {
            if (buyedpriceTextBox.Text.Trim().Length == 0)
            {
                buyedpricecrossPictureBox.Visible = true;
                validate_buyedprice = false;
            }
            else
            {
                buyedpricecrossPictureBox.Visible = false;
                validate_buyedprice = true;
            }
        }

        private void stocknumericUpDown_Leave(object sender, EventArgs e)
        {
            if(stocknumericUpDown.Value == 0)
            {
                stockcrossPictureBox.Visible = true;
                validate_stock = false;
            }
            else
            {
                stockcrossPictureBox.Visible = false;
                validate_stock = true;
            }

        }

        private void desirednumericUpDown_Leave(object sender, EventArgs e)
        {
            if (desirednumericUpDown.Value == 0)
            {
                desiredCrossPictureBox.Visible = true;
                validate_desired = false;
            }
            else
            {
                desiredCrossPictureBox.Visible = false;
                validate_desired = true;
            }

        }

        private void providerComboBox_Leave(object sender, EventArgs e)
        {
            string item = (providerComboBox.GetItemText(providerComboBox.SelectedItem)).ToString();
            if (item == "Seleccione Item")
            {
                providercrossPictureBox.Visible = true;
                validate_provider = false;

            }
            else
            {
                providercrossPictureBox.Visible = false;
                validate_provider = true;
            }

        }

        private void typeComboBox_Leave(object sender, EventArgs e)
        {
            string item = (typeComboBox.GetItemText(typeComboBox.SelectedItem)).ToString();
            if (item == "Seleccione Item")
            {
                typecrossPictureBox.Visible = true;
                validate_type = false;

            }
            else
            {
                typecrossPictureBox.Visible = false;
                validate_type = true;
            }

        }

        private void categoryComboBox_Leave(object sender, EventArgs e)
        {
            string item = (categoryComboBox.GetItemText(categoryComboBox.SelectedItem)).ToString();
            if (item == "Seleccione Item")
            {
                categorycrossPictureBox.Visible = true;
                validate_category = false;

            }
            else
            {
                categorycrossPictureBox.Visible = false;
                validate_category = true;
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            if (validate_code == false || validate_name == false || validate_saleprice == false || validate_buyedprice == false || validate_stock == false || validate_desired == false || validate_provider == false || validate_type == false || validate_category == false)
            {
                MessageBox.Show("Datos incorrectos o incompletos");
            }
            else
            {
                product.Codigo = codeTextBox.Text.Trim();
                product.Nombre = Utils.FirstLetterToUpeer(nameTextBox.Text.Trim());
                product.Precio_venta = Int32.Parse(salepriceTextBox.Text);
                product.Precio_compra = Int32.Parse(buyedpriceTextBox.Text);
                product.Cantidad_actual = Decimal.ToInt32(stocknumericUpDown.Value);
                product.Cantidad_deseada = Decimal.ToInt32(stocknumericUpDown.Value);
                product.Proveedor = Int32.Parse(providerComboBox.SelectedValue.ToString());
                product.Tipo = Int32.Parse(typeComboBox.SelectedValue.ToString());
                product.Categoria = Int32.Parse(categoryComboBox.SelectedValue.ToString());

                int result = Database.addProduct(product);
                if (result > 0)
                {
                    try
                    {
                        MessageBox.Show("Producto ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }

                }
                else
                {
                }
            }

        }

        private void addProducts_Load(object sender, EventArgs e)
        {

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
