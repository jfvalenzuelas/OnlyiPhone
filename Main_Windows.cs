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
    public partial class Main_Windows : Form
    {
        public string send_username;
        public Main_Windows()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Principal";
        }

        private bool mouseDown;
        private Point lastLocation;
        DateTime date;


        private void Main_Windows1_Load(object sender, EventArgs e)
        {
            date = DateTime.Now;
            int count = Database.getTotalSales(date.Date);
            Cashboxs cashboxs = new Cashboxs();
            cashboxs = Database.findCashBox(date.Date);
            int client = Database.getTotalClient(date.Date);
            int product = Database.getTotalProduct(date.Date);
            int work_orders = Database.getTotalWorkOrder(date.Date);

            this.CenterToScreen();
            containerPanel.Controls.Add(main.Instance);
            main.Instance.Dock = DockStyle.Fill;
            main.Instance.salenumber = count;
            main.Instance.total_account = cashboxs.income;
            main.Instance.total_client = client;
            main.Instance.total_product = product;
            main.Instance.total_work_order = work_orders;
            main.Instance.BringToFront();
            welcomeLabel.Text = send_username;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            int count = Database.getTotalSales(date.Date);
            Cashboxs cashboxs = new Cashboxs();
            cashboxs = Database.findCashBox(date.Date);
            int client = Database.getTotalClient(date.Date);
            int product = Database.getTotalProduct(date.Date);
            int work_orders = Database.getTotalWorkOrder(date.Date);

            if (!containerPanel.Controls.Contains(main.Instance))
            {
                containerPanel.Controls.Add(main.Instance);
                main.Instance.Dock = DockStyle.Fill;
                main.Instance.salenumber = count;
                main.Instance.total_account = cashboxs.income;
                main.Instance.total_client = client;
                main.Instance.total_product = product;
                main.Instance.total_work_order = work_orders;
                main.Instance.BringToFront();
            }
            else
            {
                main.Instance.salenumber = count;
                main.Instance.total_account = cashboxs.income;
                main.Instance.total_client = client;
                main.Instance.total_product = product;
                main.Instance.total_work_order = work_orders;
                main.Instance.BringToFront();
            }
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

        private void providersButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(providers.Instance))
            {
                containerPanel.Controls.Add(providers.Instance);
                providers.Instance.username = send_username;
                providers.Instance.Dock = DockStyle.Fill;
                providers.Instance.BringToFront();
            }
            else
            {
                providers.Instance.BringToFront();
            }
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(products.Instance))
            {
                containerPanel.Controls.Add(products.Instance);
                products.Instance.Dock = DockStyle.Fill;
                products.Instance.BringToFront();
            }
            else
            {
                products.Instance.BringToFront();
            }
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(client.Instance))
            {
                containerPanel.Controls.Add(client.Instance);
                client.Instance.Dock = DockStyle.Fill;
                client.Instance.BringToFront();
            }
            else
            {
                client.Instance.BringToFront();
            }
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(sale.Instance))
            {
                date = DateTime.Now;
                Cashboxs cashbox = new Cashboxs();
                cashbox = Database.findCashBox(date.Date);
                if(cashbox.date != date.Date)
                {
                    MessageBox.Show("Inicia la caja del dia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    containerPanel.Controls.Add(sale.Instance);
                    sale.Instance.Dock = DockStyle.Fill;
                    sale.Instance.BringToFront();
                    sale.Instance.username = send_username;
                }
                

                
            }
            else
            {
                sale.Instance.BringToFront();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(users.Instance))
            {
                containerPanel.Controls.Add(users.Instance);
                users.Instance.username1 = send_username;
                users.Instance.Dock = DockStyle.Fill;
                users.Instance.BringToFront();
            }
            else
            {
                users.Instance.BringToFront();
            }

        }

        private void cashboxButton_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            Cashboxs cashboxs = new Cashboxs();
            cashboxs = Database.findCashBox(date.Date);
            if (!containerPanel.Controls.Contains(cashbox.Instance))
            {
                containerPanel.Controls.Add(cashbox.Instance);
                cashbox.Instance.income = cashboxs.income;
                cashbox.Instance.outcome = cashboxs.outcome;
                cashbox.Instance.id = send_username;
                cashbox.Instance.Dock = DockStyle.Fill;
                cashbox.Instance.BringToFront();
                
            }
            else
            {
                cashbox.Instance.income = cashboxs.income;
                cashbox.Instance.outcome = cashboxs.outcome;
                cashbox.Instance.BringToFront();
                
            }
            



        }

        private void pictureBox_config_Click(object sender, EventArgs e)
        {
            Config configWindow = new Config();
            configWindow.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stats_button_Click(object sender, EventArgs e)
        {
            if (!containerPanel.Controls.Contains(stats.Instance))
            {
                containerPanel.Controls.Add(stats.Instance);
                stats.Instance.Dock = DockStyle.Fill;
                stats.Instance.BringToFront();
            }
            else
            {
                stats.Instance.BringToFront();
            }
        }

        private void btn_minimize_sidemenu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 135)
            {
                menuPanel.Width = 35;
                menuPanelLogo.Width = 35;
                welcomeLabel.Hide();
                userPicture.Hide();
                /*if (containerPanel.Controls.Contains(main.Instance))
                {
                    main.Instance.Dock = DockStyle.Fill;
                    main.Instance.Width = containerPanel.Width;
                }*/
            }
            else
            {
                menuPanel.Width = 135;
                menuPanelLogo.Width = 135;
                welcomeLabel.Show();
                userPicture.Show();

                /*if (containerPanel.Controls.Contains(main.Instance))
                {
                    main.Instance.Dock = DockStyle.Fill;
                    main.Instance.Width = containerPanel.Width;
                }*/
            }
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
