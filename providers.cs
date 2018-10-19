using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OnlyIphone
{
    public partial class providers : UserControl
    {
        public string username;
        public bool resize = false;
        private static providers _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static providers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new providers();
                return _instance;
            }
        }
        public providers()
        {
            InitializeComponent();
            

        }

  

        int id;
        string name;
        int phone;
        string email;
        string address;
        string city;

        private void button1_Click(object sender, EventArgs e)
        {
            addProviders newProvider = new addProviders();
            newProvider.ShowDialog();
            List<Provider> list = new List<Provider>();
            list = Database.listProviders();
            gridView_providers.DataSource = list;

            


        }

        private void providers_Load(object sender, EventArgs e)
        {
            List<Provider> list = new List<Provider>();
            list = Database.listProviders();
            gridView_providers.DataSource = list;
            gridView_providers.RowHeadersWidth = 18;
            gridView_providers.Columns[0].Visible = false;
            gridView_providers.Columns[6].Visible = false;
            

        }

        private void gridView_providers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(username == "admin")
            {
                button_edit.Enabled = true;
                button_disable.Enabled = true;
            }
            
            try
            {
                id = Convert.ToInt32(gridView_providers.Rows[e.RowIndex].Cells[0].Value.ToString());
                name = gridView_providers.Rows[e.RowIndex].Cells[1].Value.ToString();
                phone = Convert.ToInt32(gridView_providers.Rows[e.RowIndex].Cells[2].Value.ToString());
                email = gridView_providers.Rows[e.RowIndex].Cells[3].Value.ToString();
                address = gridView_providers.Rows[e.RowIndex].Cells[4].Value.ToString();
                city = gridView_providers.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            catch (Exception k)
            {
                Console.WriteLine(k);
            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            editProvider editprovider = new editProvider();
            editprovider.id = id;
            editprovider.name = name;
            editprovider.phone = phone;
            editprovider.email = email;
            editprovider.address = address;
            editprovider.city = city;
            if(username == "admin")
            {
                button_edit.Enabled = false;
                button_disable.Enabled = false;
            }
            
            editprovider.ShowDialog();
            List<Provider> list = new List<Provider>();
            list = Database.listProviders();
            gridView_providers.DataSource = list;

        }


        private void textbox_search_KeyUp(object sender, KeyEventArgs e)
        {
            List<Provider> list = new List<Provider>();
            if (name_radioButton.Checked)
            {
                list = Database.findProvider(textbox_search.Text);
                gridView_providers.DataSource = list;
            }
            else
            {

            }
        }

        private void button_disable_Click(object sender, EventArgs e)
        {
            string message = "Realmente desea deshabilitar el proveedor?";
            string caption = "Confirmar deshabilitacion de proveedor";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                int result = Database.disableProvider(id);
                if (result > 0)
                {
                    try
                    {
                        List<Provider> list = new List<Provider>();
                        list = Database.listProviders();
                        gridView_providers.DataSource = list;
                        MessageBox.Show("Proveedor deshabilitado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }
                }
            }
            if(username == "admin")
            {
                button_edit.Enabled = false;
                button_disable.Enabled = false;
            }
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disableProviders dis = new disableProviders();
            dis.ShowDialog();
            List<Provider> list = new List<Provider>();
            list = Database.listProviders();
            gridView_providers.DataSource = list;
        }

        private void providers_Paint(object sender, PaintEventArgs e)
        {
            if(username == "admin")
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
               
            
        }

        private void label_buscar_Click(object sender, EventArgs e)
        {

        }

        private void dayNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void providers_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.panel2.Left = this.panel2.Left - 50;
                this.gridView_providers.Left = this.gridView_providers.Left - 50;
                this.buttonPanel.Left = this.buttonPanel.Left - 50;
                this.name_radioButton.Left = this.name_radioButton.Left - 50;
                this.resize = false;
            }
            else
            {
                this.panel2.Left = this.panel2.Left + 50;
                this.gridView_providers.Left = this.gridView_providers.Left + 50;
                this.buttonPanel.Left = this.buttonPanel.Left + 50;
                this.name_radioButton.Left = this.name_radioButton.Left + 50;
                this.resize = true;
            }
        }
    }
}
