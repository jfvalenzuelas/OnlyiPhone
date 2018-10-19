using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Sales_Display
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int total_account { get; set; }
        public string payment_method { get; set; }
        public DateTime cashbox_date { get; set; }
        public string client { get; set; }
        public string username { get; set; }

        public Sales_Display()
        {

        }
        public Sales_Display(int id,DateTime date, int total_account, string payment_method, DateTime cashbox_date, string client, string username)
        {
            this.id = id;
            this.date = date;
            this.total_account = total_account;
            this.payment_method = payment_method;
            this.cashbox_date = cashbox_date;
            this.client = client;
            this.username = username;

        }
    }
}
