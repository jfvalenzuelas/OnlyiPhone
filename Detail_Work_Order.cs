using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Detail_Work_Order
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public int total_price { get; set; }
        public int work_order { get; set; }
        public string product { get; set; }

        public Detail_Work_Order()
        {

        }
        public Detail_Work_Order(int id, int quantity, int total_price, int work_order, string product)
        {
            this.id = id;
            this.quantity = quantity;
            this.total_price = total_price;
            this.work_order = work_order;
            this.product = product;
        }
    }
}
