using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Detail
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public int total_price { get; set; }
        public int sale { get; set; }
        public string product { get; set; }

        public Detail()
        {

        }
        public Detail(int id, int quantity, int total_price, int sale, string product)
        {
            this.id = id;
            this.quantity = quantity;
            this.total_price = total_price;
            this.sale = sale;
            this.product = product;
        }

    }
}
