using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Web;

namespace OnlyIphone
{
    public partial class modifyTextWork : Form
    {

        public modifyTextWork()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void modifyTextWork_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = getInfoAppSettings("workOrderText");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string newText = richTextBox1.Text;
            AddOrUpdateAppSettings("workOrderText", newText);
            this.Close();

        }

        public static string getInfoAppSettings(string key)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                return settings[key].Value;
            }
            catch(ConfigurationErrorsException){
                Console.WriteLine("Key or Info could not be found");
                return "Data not found";
            }
        }
        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string oldValue = config.AppSettings.Settings[key].Value;
                config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
