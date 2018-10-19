using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Work_Order_Display
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int total_account { get; set; }
        public string payment_method { get; set; }
        public string description { get; set; }
        public DateTime cashbox_date { get; set; }
        public string client { get; set; }
        public string username { get; set; }
        

        public Work_Order_Display()
        {

        }
        public Work_Order_Display(int Id, DateTime date, int total_account, string payment_method, string description, DateTime cashbox_date, string client, string username)
        {
            this.Id = Id;
            this.date = date;
            this.total_account = total_account;
            this.payment_method = payment_method;
            this.description = description;
            this.cashbox_date = cashbox_date;
            this.client = client;
            this.username = username;
            

        }
    }
}
