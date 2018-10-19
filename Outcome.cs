using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Outcome
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int value { get; set; }
        public string description { get; set; }
        public string username { get; set; }

        public Outcome()
        {

        }

        public Outcome(int id, DateTime date, int value, string description, string username)
        {
            this.id = id;
            this.date = date;
            this.value = value;
            this.description = description;
            this.username = username;
        }
    }
}
