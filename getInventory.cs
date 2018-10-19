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
    public partial class getInventory : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        bool validate_provider = false;

        public getInventory()
        {
            InitializeComponent();
            this.CenterToScreen();

            providercomboBox.DataSource = load_provider();
            providercomboBox.DisplayMember = "name";
            providercomboBox.ValueMember = "id";
        }

        private DataTable load_provider()
        {
            int active = 1;
            DataTable dt = new DataTable();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT id, name FROM provider WHERE active={0}", active), Connection.getConnection());
            MySqlDataAdapter adap = new MySqlDataAdapter(_comando);
            adap.Fill(dt);
            DataRow row = dt.NewRow();
            row["id"] = 0;
            row["name"] = "Seleccione Proveedor";

            dt.Rows.InsertAt(row, 0);
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (validate_provider == false)
            {
                MessageBox.Show("Por favor seleccione un proveedor");
            }
            else
            {
                int provider_id = Int32.Parse(providercomboBox.SelectedValue.ToString());
                int elements_q = Database.providersProducts(provider_id).Count;
                if (elements_q > 0)
                {
                    Provider prv = Database.getProvider(provider_id);

                    DateTime date = DateTime.Now;

                    string path = "C:\\OnlyiPhoneFiles\\Solicitudes de Inventario\\";
                    string filename = path + "Solicitud_" + prv.Name + "_" + date.Day.ToString() + "_" + date.Month.ToString() + "_" + date.Year.ToString()+".pdf";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 40, 30, 50, 30);
                    var output = new FileStream(filename, FileMode.Create);
                    PdfWriter writer = PdfWriter.GetInstance(doc, output);
                    doc.Open();

                    var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 14);
                    var boltFond = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    doc.Add(Chunk.NEWLINE);

                    Paragraph title = new Paragraph();
                    title.Add(new Chunk("Solicitud de Inventario", boltFond));
                    title.Alignment = Element.ALIGN_TOP;
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    Paragraph date_time = new Paragraph();
                    date_time.Alignment = Element.ALIGN_CENTER;
                    date_time.Add(new Chunk(date.ToString(), normalFont));
                    doc.Add(date_time);

                    Paragraph proveedor = new Paragraph();
                    proveedor.Add(new Chunk("Proveedor: " + prv.Name, normalFont));
                    proveedor.Alignment = Element.ALIGN_CENTER;
                    doc.Add(proveedor);

                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources._18740092_1851243531863286_2642745955361773779_n, System.Drawing.Imaging.ImageFormat.Png);
                    imagen.BorderWidth = 0;
                    imagen.Alignment = Element.ALIGN_TOP;
                    imagen.Alignment = Element.ALIGN_LEFT;
                    float percentage = 0.0f;
                    percentage = 110 / imagen.Width;
                    imagen.ScalePercent(percentage * 100);
                    imagen.SetAbsolutePosition(40, 630);
                    doc.Add(imagen);

                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));
                    doc.Add(new Chunk("\n"));

                    PdfPTable table = new PdfPTable(3);
                    table.AddCell(new Phrase("Código"));
                    table.AddCell(new Phrase("Item"));
                    table.AddCell(new Phrase("Cantidad a solicitar"));
                    table.AddCell(new Phrase(Chunk.NEWLINE));
                    table.AddCell(new Phrase(Chunk.NEWLINE));
                    table.AddCell(new Phrase(Chunk.NEWLINE));


                    foreach (Product prod in Database.providersProducts(provider_id))
                    {
                        table.AddCell(prod.Codigo.ToString());
                        table.AddCell(prod.Nombre.ToString());
                        table.AddCell(prod.Cantidad_faltante.ToString());
                    }
                    foreach (PdfPRow row in table.Rows)
                    {
                        foreach (PdfPCell cell in row.GetCells())
                        {
                            cell.Border = 0;
                        }
                    }

                    doc.Add(table);

                    doc.Close();

                    System.Diagnostics.Process.Start(filename);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No existen productos asociados al proveedor o el proveedor no posee productos habilitados");
                }
            }
        }

        private void providercomboBox_Leave(object sender, EventArgs e)
        {
            string item = (providercomboBox.GetItemText(providercomboBox.SelectedItem)).ToString();
            if (item == "Seleccione Item")
            {
                validate_provider = false;

            }
            else
            {
                validate_provider = true;
            }
        }
    }
}
