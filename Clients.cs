using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Clients
    {
        public string Rut { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public Clients()
        {

        }

        public Clients(string Rut, string Name, string Last_Name, string Email, int Phone, string Address)
        {
            this.Rut = Rut;
            this.Name = Name;
            this.Last_name = Last_name;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
        }

    }
}
