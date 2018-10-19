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
    
    public partial class main : UserControl
    {
        public int salenumber;
        public int total_account;
        public int total_client;
        public int total_product;
        public int total_work_order;
        public bool resize = false;
        private static main _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static main Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new main();
                return _instance;
            }
        }

        public main()
        {
 
              InitializeComponent();
              timer1.Enabled = true;

        }

        private void main_Load(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
            dayNumerLabel.Text = dateValue.ToString("dd");
            dayNameLabel.Text = Utils.FirstLetterToUpeer(dateValue.ToString("dddd"));
            monthLabel.Text = Utils.FirstLetterToUpeer(dateValue.ToString("MMMM"));
            yearLabel.Text = dateValue.ToString("yyyy");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("T");
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {
            salesNumberLabel.Text = salenumber.ToString();
            totalcountLabel.Text = total_account.ToString("C");
            clientsNumberLabel.Text = total_client.ToString();
            productsNumberLabel.Text = total_product.ToString();
            ordersNumberLabel.Text = total_work_order.ToString();
        }

        private void productsNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void productsLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void clientsNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientsLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ordersNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void ordersLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dayNumerLabel_Click(object sender, EventArgs e)
        {

        }

        private void dayNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void monthLabel_Click(object sender, EventArgs e)
        {

        }

        private void yearLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.datePanel.Left = this.datePanel.Left - 50;
                this.salesPanel.Left = this.salesPanel.Left - 50;
                this.productsPanel.Left = this.productsPanel.Left - 50;
                this.ordersPanel.Left = this.ordersPanel.Left - 50;
                this.clientsPanel.Left = this.clientsPanel.Left - 50;
                this.resize = false;
            }
            else
            {
                this.datePanel.Left = this.datePanel.Left + 50;
                this.salesPanel.Left = this.salesPanel.Left + 50;
                this.productsPanel.Left = this.productsPanel.Left + 50;
                this.ordersPanel.Left = this.ordersPanel.Left + 50;
                this.clientsPanel.Left = this.clientsPanel.Left + 50;
                this.resize = true;
            }
        }
    }
}
