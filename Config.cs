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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void button_modify1_Click(object sender, EventArgs e)
        {
            modifyTextWork auxWindow = new modifyTextWork();
            auxWindow.Show();
        }

        private void box_close_Click(object sender, EventArgs e)
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
    }
}
