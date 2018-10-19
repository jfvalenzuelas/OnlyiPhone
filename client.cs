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
    public partial class client : UserControl
    {
        public bool resize = false;
        private static client _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static client Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new client();
                return _instance;
            }
        }
        public client()
        {
            InitializeComponent();
        }
    

        private void client_Load(object sender, EventArgs e)
        {
            List<Clients> client = new List<Clients>();
            client = Database.listClient();
            gridView_clients.DataSource = client;
            gridView_clients.RowHeadersWidth = 18;
            gridView_clients.Columns[0].Width = 170;
            gridView_clients.Columns[0].HeaderText = "Rut";
            gridView_clients.Columns[1].HeaderText = "Nombre";
            gridView_clients.Columns[2].HeaderText = "Apellido";
            gridView_clients.Columns[3].HeaderText = "Email";
            gridView_clients.Columns[4].HeaderText = "Teléfono";
            gridView_clients.Columns[5].HeaderText = "Dirección";

        }

        private void textbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textbox_search_KeyUp(object sender, KeyEventArgs e)
        {
            List<Clients> list = new List<Clients>();

            if (code_radioButton.Checked)
            {
                list = Database.findClients(textbox_search.Text.Trim());
                gridView_clients.DataSource = list;


            }
            else
            {

            }
        }

    

        private void client_Paint(object sender, PaintEventArgs e)
        {
            List<Clients> client = new List<Clients>();
            client = Database.listClient();
            gridView_clients.DataSource = client;
        }

        private void client_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.label_title_list.Left = this.label_title_list.Left - 50;
                this.label_buscar.Left = this.label_buscar.Left - 50;
                this.panel1.Left = this.panel1.Left - 50;
                this.textbox_search.Left = this.textbox_search.Left - 50;
                this.code_radioButton.Left = this.code_radioButton.Left - 50;
                this.gridView_clients.Left = this.gridView_clients.Left - 50;
                this.resize = false;
            }
            else
            {
                this.label_title_list.Left = this.label_title_list.Left + 50;
                this.label_buscar.Left = this.label_buscar.Left + 50;
                this.panel1.Left = this.panel1.Left + 50;
                this.textbox_search.Left = this.textbox_search.Left + 50;
                this.code_radioButton.Left = this.code_radioButton.Left + 50;
                this.gridView_clients.Left = this.gridView_clients.Left + 50;
                this.resize = true;
            }
        }
    }
}
