using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OnlyIphone
{
    public partial class stats : UserControl
    {
        public string username;
        public bool resize = false;
        private static stats _instance;

        public static stats Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new stats();
                return _instance;
            }
        }

        public stats()
        {
            InitializeComponent();
            sales_chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            sales_chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            Int32 total = 0;
            Int32 max = 0;
            Int32 min = 0;
            List<Int32> tmp = new List<Int32>();
            List<Sales> sales = Database.findAllSales();

            //Console.WriteLine("GENERANDO CHART");
            sales_chart.Series["Ventas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            sales_chart.Series["Ventas"].Color = Color.Green;
            sales_chart.Series["Ventas"].Points.Clear();
            sales_chart.Series["Ventas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            sales_chart.Series["Ventas"].Color = Color.Green;


            foreach (Sales sale in sales)
            {
                //Console.WriteLine(sale.cashbox_date);
                //Console.WriteLine(sale.total_account);
                //Console.WriteLine("\n");
                sales_chart.Series["Ventas"].Points.AddXY(sale.cashbox_date, sale.total_account);
                tmp.Add(sale.total_account);
                total = total + sale.total_account;
            }
            max = tmp.Max();
            min = tmp.Min();
            total_label.Text = " $ " + total;
            total_label.Text = total_label.Text + " (Máximo: $" + max.ToString() + ", Mínimo: $" + min.ToString() + ")";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label_title_cashbox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void load_data_button_Click(object sender, EventArgs e)
        {
            Int32 max = 0;
            Int32 min = 0;
            List<Int32> tmp = new List<Int32>();
            Int32 total = Database.getTotalSales(date1.Value, date2.Value);
            total_label.Text = " $ "+total.ToString();
            //Console.WriteLine("GENERANDO CHART");
            sales_chart.Series["Ventas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            sales_chart.Series["Ventas"].Color = Color.Green;
            sales_chart.Series["Ventas"].Points.Clear();
            sales_chart.Series["Ventas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            sales_chart.Series["Ventas"].Color = Color.Green;

            List<Sales> sales = new List<Sales>();
            sales = Database.findSales(date1.Value, date2.Value);
            foreach(Sales sale in sales)
            {
                //Console.WriteLine(sale.cashbox_date);
                //Console.WriteLine(sale.total_account);
                //Console.WriteLine("\n");
                sales_chart.Series["Ventas"].Points.AddXY(sale.cashbox_date, sale.total_account);
                tmp.Add(sale.total_account);
            }
            max = tmp.Max();
            min = tmp.Min();
            total_label.Text = total_label.Text + " (Máximo: $" + max.ToString()+", Mínimo: $"+min.ToString()+")";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sales_chart_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pdf_button_Click(object sender, EventArgs e)
        {
            DateTime date_from = date1.Value;
            DateTime date_until = date2.Value;
            String f1 = date_from.ToShortDateString();
            String f2 = date_until.ToShortDateString();
            f1 = f1.Replace('/', '-');
            f2 = f2.Replace('/', '-');
            Console.WriteLine(f1 + " -- " + f2);
            string path = "C:\\OnlyiPhoneFiles\\Informes\\";
            string filename = path + "Informe_"+f1+"_"+f2+".pdf";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 40, 30, 50, 30);
            var output = new FileStream(filename, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(doc, output);
            doc.Open();

            DateTime date = DateTime.Now;
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 14);
            var boltFond = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
            doc.Add(Chunk.NEWLINE);

            Paragraph title = new Paragraph();
            title.Add(new Chunk("Informe de Ventas", boltFond));
            title.Alignment = Element.ALIGN_TOP;
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            Paragraph date_time = new Paragraph();
            date_time.Alignment = Element.ALIGN_CENTER;
            date_time.Add(new Chunk(date.ToString(), normalFont));
            doc.Add(date_time);

            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));
            doc.Add(new Chunk("\n"));

            Paragraph date_range = new Paragraph();
            date_range.Add(new Chunk("\nDesde " + date_from.Date.ToString() + ", Hasta " + date_until.Date.ToString(), normalFont));
            date_range.Alignment = Element.ALIGN_LEFT;
            doc.Add(date_range);

            doc.Add(new Chunk("\n"));

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources._18740092_1851243531863286_2642745955361773779_n, System.Drawing.Imaging.ImageFormat.Png);
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_TOP;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 110 / imagen.Width;
            imagen.ScalePercent(percentage * 100);
            imagen.SetAbsolutePosition(40, 630);
            doc.Add(imagen);

            PdfPTable table = new PdfPTable(4);
            table.AddCell(new Phrase("Fecha"));
            table.AddCell(new Phrase("Venta"));
            table.AddCell(new Phrase("Vendedor"));
            table.AddCell(new Phrase("Monto"));

            List<Sales> sales_list = Database.findSalesToFile(date1.Value, date2.Value);
            foreach (Sales sale in sales_list)
            {
                table.AddCell(new Phrase(sale.date.ToString()));
                table.AddCell(new Phrase(sale.id.ToString()));
                table.AddCell(new Phrase(sale.username.ToString()));
                table.AddCell(new Phrase(sale.total_account.ToString()));
            }

            PdfPTable total_amount = new PdfPTable(1);
            PdfPCell separator = new PdfPCell(new Phrase(Chunk.NEWLINE));
            separator.BorderWidthBottom = 0;
            separator.BorderWidthLeft = 0;
            separator.BorderWidthRight = 0;
            separator.BorderWidthTop = 1;

            string total_detail = "Total de Ventas    $  " + Database.getTotalSales(date1.Value, date2.Value).ToString();

            PdfPCell tmp3 = new PdfPCell(new Phrase(total_detail));
            tmp3.Border = 0;
            tmp3.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            total_amount.AddCell(separator);
            total_amount.AddCell(tmp3);

            doc.Add(new Chunk("\n"));
            doc.Add(table);
            doc.Add(total_amount);

            doc.Close();

            System.Diagnostics.Process.Start(filename);
        }

        private void stats_Load(object sender, EventArgs e)
        {

        }

        private void stats_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.panel1.Left = this.panel1.Left - 50;
                this.sales_chart.Left = this.sales_chart.Left - 50;
                this.label3.Left = this.label3.Left - 50;
                this.pdf_button.Left = this.pdf_button.Left - 50;
                this.total_label.Left = this.total_label.Left - 50;
                this.resize = false;
            }
            else
            {
                this.panel1.Left = this.panel1.Left + 50;
                this.sales_chart.Left = this.sales_chart.Left + 50;
                this.label3.Left = this.label3.Left + 50;
                this.pdf_button.Left = this.pdf_button.Left + 50;
                this.total_label.Left = this.total_label.Left + 50;
                this.resize = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
