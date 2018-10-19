using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Provider
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Active { get; set; }

        public Provider()
        {

        }

        public Provider(int Id, string Name, int Phone, string Email, string Address, string City, int Active)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.City = City;
            this.Active= Active;
        }
    }
}
