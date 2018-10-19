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
    public partial class cashbox : UserControl
    {
        public int income;
        public int outcome;
        public string id;
        public bool resize = false;
        private static cashbox _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static cashbox Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new cashbox();
                return _instance;
            }
        }

        public cashbox()
        {
            InitializeComponent();
        }
        DateTime date;

        private void cashbox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd-MM-yyyy"));

            Cashboxs cashbox = new Cashboxs();
            cashbox.date = date.Date;

            int result = Database.addCashBox(cashbox);
            if(result > 0)
            {
                MessageBox.Show("Caja iniciada, Dia "+date.ToString("dd-MM-yyyy"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        private void cashbox_Paint(object sender, PaintEventArgs e)
        {
            totalcountLabel.Text = income.ToString("C");
            totalOutcomeLabel.Text = outcome.ToString("C");
        }

        private void button_addOutcome_Click(object sender, EventArgs e)
        {
            if(textBox_value.Text.Trim().Length == 0 || textBox_description.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese todos los datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                date = DateTime.Now;
                Cashboxs cashboxs1 = new Cashboxs();
                cashboxs1 = Database.findCashBox(date.Date);
                Console.WriteLine(cashboxs1.date);
                Console.WriteLine(cashboxs1.income);
                Console.WriteLine(cashboxs1.outcome);

                if (cashboxs1.date != date.Date) 
                {
                    MessageBox.Show("Inicie la caja del día", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime date = DateTime.Now;
                    Outcome outcome = new Outcome();
                    outcome.date = date.Date;
                    outcome.value = Convert.ToInt32(textBox_value.Text.Trim());
                    outcome.description = textBox_description.Text.Trim();
                    outcome.username = id;
                    int resultado = Database.addOutcome(outcome);
                    if (resultado > 0)
                    {
                        Cashboxs cashbox = new Cashboxs();
                        cashbox.outcome = Convert.ToInt32(textBox_value.Text.Trim());
                        cashbox.date = date.Date;
                        int result = Database.updateCashBox(cashbox, "outcome");
                        if (result > 0)
                        {
                            MessageBox.Show("Egreso ingresado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_value.Text = "";
                            textBox_description.Text = "";
                            date = DateTime.Now;
                            Cashboxs cashboxs = new Cashboxs();
                            cashboxs = Database.findCashBox(date.Date);
                            totalcountLabel.Text = cashbox.income.ToString("C");
                            totalOutcomeLabel.Text = cashbox.outcome.ToString("C");
                        }
                    }
                }
                
            }

        }

        private void textBox_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cashbox_Resize(object sender, EventArgs e)
        {
            if (this.resize)
            {
                this.income_panel.Left = this.income_panel.Left - 50;
                this.outcome_panel.Left = this.outcome_panel.Left - 50;
                this.outcome_input_group.Left = this.outcome_input_group.Left - 50;
                this.button1.Left = this.button1.Left - 50;
                this.resize = false;
            }
            else
            {
                this.income_panel.Left = this.income_panel.Left + 50;
                this.outcome_panel.Left = this.outcome_panel.Left + 50;
                this.outcome_input_group.Left = this.outcome_input_group.Left + 50;
                this.button1.Left = this.button1.Left + 50;
                this.resize = true;
            }
        }
    }
}
