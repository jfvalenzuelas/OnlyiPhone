using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Payment_method
    {
        public int Id { get; set; }
        public string Type { get; set; }
        

        public Payment_method()
        {

        }
        public Payment_method(int Id,string Type)
        {
            this.Id = Id;
            this.Type = Type;

        }
    }
}
