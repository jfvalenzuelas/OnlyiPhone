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
    public partial class users : UserControl
    {
        public string username1;
        public bool resize = false;
        private static users _instance;
        public users()
        {
            InitializeComponent();
        }
        string username;
        string password;
        public static users Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new users();
                return _instance;
            }
        }

    

        private void gridView_providers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            username = gridView_users.Rows[e.RowIndex].Cells[0].Value.ToString();
            password = gridView_users.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            button_edit.Enabled = true;
        }

        private void users_Load(object sender, EventArgs e)
        {
            List<User> list = new List<User>();
            list = Database.listUsers();
            gridView_users.DataSource = list;
            gridView_users.RowHeadersWidth = 18;
            gridView_users.Columns[1].Visible = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            changepass.Visible = true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            changepass.Visible = false;
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;
           if (newpass_TextBox.Text.Trim() == newpass_TextBox1.Text.Trim())
            {
                int result = Database.updateUser(user, oldpass_TextBox.Text.Trim(), newpass_TextBox.Text.Trim());
                if (result > 0)
                {
                    try
                    {
                        MessageBox.Show("Contraseña modificada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changepass.Visible = false;
                        oldpass_TextBox.Text = "";
                        newpass_TextBox.Text = "";
                        newpass_TextBox1.Text = "";

                    }
                    catch (Exception l)
                    {
                        Console.WriteLine(l);
                    }

                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button_newUser_Click(object sender, EventArgs e)
        {
            addUser adduser = new addUser();
            adduser.ShowDialog();
            List<User> list = new List<User>();
            list = Database.listUsers();
            gridView_users.DataSource = list;
        }

        private void users_Leave(object sender, EventArgs e)
        {
            List<User> list = new List<User>();
            list = Database.listUsers();
            gridView_users.DataSource = list;
        }

        private void button_deleteUser_Click(object sender, EventArgs e)
        {

        }

        private void button_newUser_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void users_Paint(object sender, PaintEventArgs e)
        {
            if (username1 == "admin")
            {
                button_newUser.Enabled = true;
            }
        }

        private void users_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.dayNameLabel.Left = this.dayNameLabel.Left - 50;
                this.gridView_users.Left = this.gridView_users.Left - 50;
                this.changepass.Left = this.changepass.Left - 50;
                this.button_edit.Left = this.button_edit.Left - 50;
                this.button_newUser.Left = this.button_newUser.Left - 50;
                this.resize = false;
            }
            else
            {
                this.dayNameLabel.Left = this.dayNameLabel.Left + 50;
                this.gridView_users.Left = this.gridView_users.Left + 50;
                this.changepass.Left = this.changepass.Left + 50;
                this.button_edit.Left = this.button_edit.Left + 50;
                this.button_newUser.Left = this.button_newUser.Left + 50;
                this.resize = true;
            }
        }
    }
}
