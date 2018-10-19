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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OnlyIphone
{
    public partial class addSale : Form
    {
        public string username;
        public string rut;
        public addSale()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        string code;
        string name;
        int sale_price;
        int count;
        string code1;
        string name1;
        int sale_price1;
        int count1;
        public DataTable detail_table;
        public DataRow row_detail;
        bool validate_rut;
        bool validate_email;
        DateTime date;
        int total;
        int subtotal;
        int resultado_insert_detail;






        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addSale_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Text = "Nueva Venta";

            //Label para obtener el usuario logueado y desplegarlo en la pantalla
            label_user.Text = "Usuario: " + username;

            //Lista de productos disponibles
            List<Product_Display> list = new List<Product_Display>();
            list = Database.listProducts("sales");
            gridView_products.DataSource = list;

            //Inicializar validadores en falso;
            validate_rut = false;
            validate_email = true;
         

            //Configuracion de GridView de productos y columnas ocultas
            gridView_products.RowHeadersWidth = 18;
            gridView_products.Columns[1].Width = 150;
            gridView_products.Columns[1].HeaderText = "Descripción";
            gridView_products.Columns[2].HeaderText = "Valor";
            gridView_products.Columns[3].Visible = false;
            gridView_products.Columns[4].Visible = false;
            gridView_products.Columns[5].Visible = false;
            gridView_products.Columns[6].Visible = false;
            gridView_products.Columns[7].Visible = false;
            gridView_products.Columns[8].Visible = false;

            //DataTable de que se cargara en GridView de Detalles
            detail_table = new DataTable();
            detail_table.Columns.Add("Código");
            detail_table.Columns.Add("Descripción");
            detail_table.Columns.Add("Cantidad");
            detail_table.Columns.Add("Total");
            detail_table.PrimaryKey = new DataColumn[] { detail_table.Columns["Código"] };

            //Relleno del comboBox de los metodos de pago
            comboBox_paymentMethods.DataSource = load_payment_method();
            comboBox_paymentMethods.DisplayMember = "type";
            comboBox_paymentMethods.ValueMember = "id";


        }
        //Método para cargar los datos de metodos de pago desde la base de datos
        private DataTable load_payment_method()
        {
            DataTable dt = new DataTable();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id, type FROM payment_method"), Connection.getConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(_comando);
            adap.Fill(dt);

            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["type"] = "Seleccione método";

            dt.Rows.InsertAt(row, 0);

            return dt; 
        }
        //Métodos para mover el panel --> MouseDown, MouseMove y MouseUp
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
        //Método para filtrar por código o nombre en el GridView de productos
        private void textbox_searchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            List<Product_Display> list = new List<Product_Display>();

            if (radioButton_code.Checked)
            {
                list = Database.findProduct(textbox_searchProduct.Text, "id","sale");
                gridView_products.DataSource = list;

            }
            else if (radioButton_description.Checked)
            {
                list = Database.findProduct(textbox_searchProduct.Text, "name","sale");
                gridView_products.DataSource = list;
            }
            else
            {
                //No se aplica ningun filtro
            }
        }
        //Método que obtiene los datos de la fila del GridView de productos cada vez que se hace click
        private void gridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_addDetail.Enabled = true;
            try
            {
                code = gridView_products.Rows[e.RowIndex].Cells[0].Value.ToString();
                name = gridView_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                sale_price = Convert.ToInt32(gridView_products.Rows[e.RowIndex].Cells[2].Value.ToString());
                count = 1;

            }
            catch (Exception k)
            {
                MessageBox.Show("El producto ya se encuentra en la venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Método para agregar un produto al DateTable y luego al GridView de Detalles
        private void button_addDetail_Click(object sender, EventArgs e)
        {
            //Se crea una nueva fila con los datos obtenido
            row_detail = detail_table.NewRow();
            row_detail["Código"] = code;
            row_detail["Descripción"] = name;
            row_detail["Cantidad"] = count;
            row_detail["Total"] = sale_price;
            //Si el producto no se encuentra en la DateTable de detalles, lo agrega, si no, es por que ya se encuentra.
            try
            {
                detail_table.Rows.Add(row_detail);
                gridView_detail.DataSource = detail_table;
                gridView_detail.Columns[1].Width = 120;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Producto ya esta en la venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            GetTotal();




        }
        //Método para incrementar la cantidad de cada producto una vez este en el GridView de detalles
        private void button_sumCount_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = Database.getProduct(code1);
            DataRow[] datos = detail_table.Select(String.Format("Código ='{0}'",code1));
            if (count1 < product.Cantidad_actual)
            {
                datos[0]["Cantidad"] = count1 + 1;
                datos[0]["Total"] = sale_price1 + product.Precio_venta;
                count1 = Convert.ToInt32(datos[0]["Cantidad"].ToString());
                sale_price1 = Convert.ToInt32(datos[0]["Total"]);
            }
            else
            {
                button_sumCount.Enabled = false;
                MessageBox.Show("Ha llegado al stock máximo del producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            gridView_detail.DataSource = detail_table;
            GetTotal();

        }
        //Método que obtiene los datos de la fila del GridView de detalle cada vez que se hace click
        private void gridView_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button_sumCount.Enabled = true;
                code1 = gridView_detail.Rows[e.RowIndex].Cells[0].Value.ToString();
                name1 = gridView_detail.Rows[e.RowIndex].Cells[1].Value.ToString();
                count1 = Convert.ToInt32(gridView_detail.Rows[e.RowIndex].Cells[2].Value.ToString());
                sale_price1 = Convert.ToInt32(gridView_detail.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (count1 > 1)
                {
                    button_subtractCount.Enabled = true;
                }
                else
                {
                    button_subtractCount.Enabled = false;
                }

            }
            catch (Exception k)
            {

            }
        }
        //Método para restar a la cantidad de cada producto una vez este en el GridView de detalles
        private void button_subtractCount_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = Database.getProduct(code1);
            DataRow[] datos = detail_table.Select(String.Format("Código ='{0}'", code1));
            if (count1 > 1)
            {
                datos[0]["Cantidad"] = count1 - 1;
                datos[0]["Total"] = sale_price1 - product.Precio_venta;
                count1 = Convert.ToInt32(datos[0]["Cantidad"].ToString());
                sale_price1 = Convert.ToInt32(datos[0]["Total"]);
            }
            else
            {
                MessageBox.Show("Cantidad mínima para venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            gridView_detail.DataSource = detail_table;
            GetTotal();
        }
        //Método para eliminar producto desde el GridView de la venta
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow[] datos = detail_table.Select(String.Format("Código ='{0}'", code1));
            detail_table.Rows[0].Delete();
            button_sumCount.Enabled = false;
            button_subtractCount.Enabled = false;
            gridView_detail.DataSource = detail_table;
            GetTotal();

        }
        //Metodo para aplicar descuento
        private void button1_Click(object sender, EventArgs e)
        {
            GetTotal();
            button_descuento.Visible = true;
        }
        //Método que refresca constantemente los valores del total, descuento y sub total.
        public void GetTotal()
        {
            subtotal = 0;
            total = 0;
            
            if (textBox_descuento.Text == "0")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            
            foreach (DataRow dtRow in detail_table.Rows)
            {
                subtotal = Convert.ToInt32(dtRow["Total"]) + subtotal;

            }
            if(textBox_descuento.Text == "")
            {
                total = subtotal;
                label_subTotal.Text = "$ " + subtotal;
                label_total.Text = "$ " + total;
            }
            else
            {
                total = subtotal - Convert.ToInt32(textBox_descuento.Text);
                label_subTotal.Text = "$ " + subtotal;
                label_total.Text = "$ " + total;
            }
            
        }

        private void button_addClient_Click(object sender, EventArgs e)
        {
            if (textBox_rut.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el rut", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (validate_rut== false)
            {
                MessageBox.Show("Rut incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(validate_email == false)
            {
                MessageBox.Show("Revise el email", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
            else
            {
                Clients client = new Clients();
                client.Rut = textBox_rut.Text.Trim();
                if(textBox_name.Text.Trim().Length != 0)
                {
                    client.Name = textBox_name.Text.Trim();
                }
                if(textBox_lastName.Text.Trim().Length != 0) {
                    client.Last_name = textBox_lastName.Text.Trim();
                }
                if(textBox_email.Text.Trim().Length != 0)
                {
                    client.Email = textBox_email.Text.Trim();
                }
                if(textBox_phone.Text.Trim().Length != 0)
                {
                    client.Phone = Convert.ToInt32(textBox_phone.Text.Trim());
                }
                if(textBox_address.Text.Trim().Length != 0)
                {
                    client.Address = textBox_address.Text.Trim();
                }

                int result = Database.addClient(client);
                if(result > 0)
                {
                    try
                    {
                        MessageBox.Show("Cliente ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_name.Enabled = false;
                        textBox_lastName.Enabled = false;
                        textBox_email.Enabled = false;
                        textBox_phone.Enabled = false;
                        textBox_address.Enabled = false;
                    }
                    catch (Exception l)
                    {

                    }
                }
            }
        }

        private void textBox_rut_Leave(object sender, EventArgs e)
        {
            if(textBox_rut.Text.Trim().Length == 0)
            {
                validate_rut = false;
                
            }
            else
            {
                if (Utils.validarRut(textBox_rut.Text.Trim()))
                {
                    validate_rut = true;
                }
                else
                {
                    validate_rut = false;
                }
            }
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            if(textBox_email.Text.Trim().Length == 0)
            {
                validate_email = true;
            }
            else
            {
                if (Utils.ComprobarFormatoEmail(textBox_email.Text.Trim()))
                {
                    validate_email = true;
                }
                else
                {
                    validate_email = false;
                }
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(e);
        }

        private void textBox_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Utils.SoloNumeros(e);
            if(textBox_rut.Text.Trim().Length == 1)
            {
                textBox_name.Enabled = true;
                textBox_lastName.Enabled = true;
                textBox_email.Enabled = true;
                textBox_phone.Enabled = true;
                textBox_address.Enabled = true;
            }
            textBox_name.Text = string.Empty;
            textBox_lastName.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_phone.Text = string.Empty;
            textBox_address.Text = string.Empty;

            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == 'k' || e.KeyChar == 'K')
                {
                    e.KeyChar = 'k';
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void button_findClient_Click(object sender, EventArgs e)
        {
            if (Utils.validarRut(textBox_rut.Text.Trim()))
            {
                
                Clients client = new Clients();
                client = Database.findClient(textBox_rut.Text.Trim());
                

                if (client.Rut == null)
                {
                    MessageBox.Show("Cliente no registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radioButton_rutSale.Checked = true;
                    textBox_name.Text = client.Name;
                    textBox_lastName.Text = client.Last_name;
                    textBox_email.Text = client.Email;
                    if(client.Phone == 0)
                    {
                        textBox_phone.Text = "";
                    }
                    else
                    {
                        textBox_phone.Text = client.Phone.ToString();
                    }
                    textBox_address.Text = client.Address;
                    textBox_name.Enabled = false;
                    textBox_lastName.Enabled = false;
                    textBox_email.Enabled = false;
                    textBox_phone.Enabled = false;
                    textBox_address.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show("Ingresa un Rut válido para realizar la búsqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Enabled = true;
                textBox_lastName.Enabled = true;
                textBox_email.Enabled = true;
                textBox_phone.Enabled = true;
                textBox_address.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTotal();
            string item = (comboBox_paymentMethods.GetItemText(comboBox_paymentMethods.SelectedItem)).ToString();
            string error = string.Empty;
            if(label_subTotal.Text.Trim() != "$ 0" && item != "Seleccione método"  && (radioButton_normalSale.Checked || radioButton_rutSale.Checked))
            {
                date = DateTime.Now;
                Sales sale = new Sales();
                sale.date = Convert.ToDateTime(date.ToString("dd-MM-yyyy HH:mm:ss"));
                sale.total_account = total;
                Console.WriteLine(total);
                sale.payment_method = Int32.Parse(comboBox_paymentMethods.SelectedValue.ToString());
                sale.cashbox_date = date.Date;
                if (radioButton_normalSale.Checked)
                {
                    sale.client = "00000000";
                    rut = "";
                }
                else
                {
                    if(textBox_rut.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Ingresa el rut del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Utils.validarRut(textBox_rut.Text.Trim()))
                        {

                            Clients client = new Clients();
                            client = Database.findClient(textBox_rut.Text.Trim());


                            if (client.Rut == null)
                            {
                                MessageBox.Show("Cliente no registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                rut = client.Rut;
                                textBox_name.Text = client.Name;
                                textBox_lastName.Text = client.Last_name;
                                textBox_email.Text = client.Email;
                                if (client.Phone == 0)
                                {
                                    textBox_phone.Text = "";
                                }
                                else
                                {
                                    textBox_phone.Text = client.Phone.ToString();
                                }
                                textBox_address.Text = client.Address;
                                textBox_name.Enabled = false;
                                textBox_lastName.Enabled = false;
                                textBox_email.Enabled = false;
                                textBox_phone.Enabled = false;
                                textBox_address.Enabled = false;

                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingresa un Rut válido para realizar la búsqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_name.Enabled = true;
                            textBox_lastName.Enabled = true;
                            textBox_email.Enabled = true;
                            textBox_phone.Enabled = true;
                            textBox_address.Enabled = true;
                        }

                    }
                    sale.client = textBox_rut.Text.Trim();
                }   
                sale.username = username;

                int result = Database.addSale(sale);

                if(result > 0)
                {
                    foreach (DataRow dtRow in detail_table.Rows)
                    {
                        Detail detail = new Detail();
                        detail.quantity = Convert.ToInt32(dtRow["Cantidad"]);
                        detail.total_price = Convert.ToInt32(dtRow["Total"]);
                        detail.sale = result;
                        detail.product = dtRow["Código"].ToString();
                        int result1 = Database.addDetail(detail);
                        resultado_insert_detail = result1;
                    }
                    if (resultado_insert_detail > 0)
                    {
                        MessageBox.Show("Venta registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (DataRow dtRow in detail_table.Rows)
                        {
                            try
                            {
                                int result2 = Database.updateStockProduct(dtRow["Código"].ToString(), Convert.ToInt32(dtRow["Cantidad"]));
                                
                            }
                            catch
                            {

                            }
                            

                        }
                        Cashboxs cashbox = new Cashboxs();
                        cashbox.date = date.Date;
                        cashbox.income = total;
                        Console.WriteLine(total);
                        int result3 = Database.updateCashBox(cashbox, "income");
                        //AQUI VA EL CODIGO PARA EL INFORME
                        string path = "C:\\OnlyiPhoneFiles\\Ventas\\";
                        string filename = path + "Venta_" + result + ".pdf";

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }

                        Document doc = new Document(iTextSharp.text.PageSize.LETTER, 40, 30, 50, 30);
                        var output = new FileStream(filename, FileMode.Create);
                        PdfWriter writer = PdfWriter.GetInstance(doc, output);
                        doc.Open();

                        date = DateTime.Now;
                        var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 14);
                        var boltFond = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                        doc.Add(Chunk.NEWLINE);



                        Paragraph title = new Paragraph();
                        title.Add(new Chunk("Detalle de Venta", boltFond));
                        title.Alignment = Element.ALIGN_TOP;
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);



                        Paragraph date_time = new Paragraph();
                        date_time.Alignment = Element.ALIGN_CENTER;
                        date_time.Add(new Chunk(date.ToString(), normalFont));
                        doc.Add(date_time);

                        Paragraph usernam = new Paragraph();
                        usernam.Add(new Chunk("Vendedor: " + username, normalFont));
                        usernam.Alignment = Element.ALIGN_CENTER;
                        doc.Add(usernam);

                        doc.Add(new Chunk("\n"));
                        doc.Add(new Chunk("\n"));
                        doc.Add(new Chunk("\n"));
                        doc.Add(new Chunk("\n"));
                        doc.Add(new Chunk("\n"));

                        Paragraph id_venta = new Paragraph();
                        id_venta.Add(new Chunk("N° Venta: " + result, normalFont));
                        id_venta.Alignment = Element.ALIGN_LEFT;
                        doc.Add(id_venta);

                        doc.Add(new Chunk("\n"));

                        Paragraph cliente = new Paragraph();
                        cliente.Add(new Chunk("Cliente: " + rut, normalFont));
                        cliente.Alignment = Element.ALIGN_LEFT;
                        doc.Add(cliente);

                        doc.Add(new Chunk("\n"));

                        Paragraph nombre = new Paragraph();
                        nombre.Add(new Chunk("Nombre: " + textBox_name.Text + " " + textBox_lastName.Text, normalFont));
                        nombre.Alignment = Element.ALIGN_LEFT;
                        doc.Add(nombre);



                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources._18740092_1851243531863286_2642745955361773779_n, System.Drawing.Imaging.ImageFormat.Png);
                        imagen.BorderWidth = 0;
                        imagen.Alignment = Element.ALIGN_TOP;
                        imagen.Alignment = Element.ALIGN_LEFT;
                        float percentage = 0.0f;
                        percentage = 110 / imagen.Width;
                        imagen.ScalePercent(percentage * 100);
                        imagen.SetAbsolutePosition(40, 630);
                        doc.Add(imagen);

                        PdfPTable table = new PdfPTable(detail_table.Columns.Count);
                        table.AddCell(new Phrase("Código"));
                        table.AddCell(new Phrase("Item"));
                        table.AddCell(new Phrase("Cantidad"));
                        table.AddCell(new Phrase("Precio"));
                        table.AddCell(new Phrase(Chunk.NEWLINE));
                        table.AddCell(new Phrase(Chunk.NEWLINE));
                        table.AddCell(new Phrase(Chunk.NEWLINE));
                        table.AddCell(new Phrase(Chunk.NEWLINE));

                        foreach (DataGridViewRow row in gridView_detail.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value.ToString());
                            }
                        }
                        foreach (PdfPRow row in table.Rows)
                        {
                            int aux = 0;
                            foreach (PdfPCell cell in row.GetCells())
                            {
                                cell.Border = 0;
                                if (aux == 2)
                                {
                                    cell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                                    aux = 3;
                                }
                                else
                                {
                                    if (aux == 3)
                                    {
                                        cell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                                        aux = 0;
                                    }
                                    else
                                    {
                                        aux += 1;
                                    }
                                }
                            }
                        }
                        PdfPTable total_amount = new PdfPTable(1);
                        PdfPCell separator = new PdfPCell(new Phrase(Chunk.NEWLINE));
                        separator.BorderWidthBottom = 0;
                        separator.BorderWidthLeft = 0;
                        separator.BorderWidthRight = 0;
                        separator.BorderWidthTop = 1;

                        string subtotal_detail = "Subtotal    $  " + subtotal;
                        string descuento_detail = "Descuento   $ -" + textBox_descuento.Text;
                        string total_detail = "Total    $  " + total;

                        PdfPCell tmp1 = new PdfPCell(new Phrase(subtotal_detail));
                        PdfPCell tmp2 = new PdfPCell(new Phrase(descuento_detail));
                        PdfPCell tmp3 = new PdfPCell(new Phrase(total_detail));
                        tmp1.BorderWidthBottom = 0;
                        tmp1.BorderWidthLeft = 0;
                        tmp1.BorderWidthRight = 0;
                        tmp1.BorderWidthTop = 1;
                        tmp1.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                        tmp2.Border = 0;
                        tmp2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                        tmp3.Border = 0;
                        tmp3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                        total_amount.AddCell(tmp1);
                        total_amount.AddCell(tmp2);
                        total_amount.AddCell(separator);
                        total_amount.AddCell(tmp3);

                        doc.Add(new Chunk("\n"));
                        doc.Add(table);
                        doc.Add(total_amount);

                        doc.Close();

                        System.Diagnostics.Process.Start(filename);

                        this.Close();

                    }
                       
                }
            }
            else
            {
                if(label_subTotal.Text.Trim() == "$ 0")
                {
                    error = "- Ingresa productos a la lista" + "\n\r";
                }
                if (item == "Seleccione método")
                {
                    error = error + "- Elige método de pago"+ "\n\r";
                }
                if (radioButton_normalSale.Checked== false && radioButton_rutSale.Checked==false)
                {
                    error = error + "- Escoge venta con/sin rut" + "\n\r";
                }
                MessageBox.Show(error, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_descuento_Click(object sender, EventArgs e)
        {
            textBox_descuento.Text = "0";
            GetTotal();
            button_descuento.Visible = false;

        }

        private void textBox_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox_descuento.Text.Trim() != "0" || textBox_descuento.Text.Trim() != "")
            {
                button1.Enabled = true;
            }
        }

        private void radioButton_normalSale_CheckedChanged(object sender, EventArgs e)
        {
            textBox_rut.Enabled = false;
            textBox_name.Enabled = false;
            textBox_lastName.Enabled = false;
            textBox_email.Enabled = false;
            textBox_phone.Enabled = false;
            textBox_address.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label9.Enabled = false;
            label6.Enabled = false;
            label4.Enabled = false;
            label12.Enabled = false;
            button_findClient.Enabled = false;
            button_addClient.Enabled = false;

        }

        private void radioButton_rutSale_CheckedChanged(object sender, EventArgs e)
        {
            textBox_rut.Enabled = true;
            textBox_name.Enabled = true;
            textBox_lastName.Enabled = true;
            textBox_email.Enabled = true;
            textBox_phone.Enabled = true;
            textBox_address.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label9.Enabled = true;
            label6.Enabled = true;
            label4.Enabled = true;
            label12.Enabled = true;
            button_findClient.Enabled = true;
            button_addClient.Enabled = true;
        }

        private void textBox_rut_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
