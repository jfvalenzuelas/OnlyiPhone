using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Cashboxs
    {
        public DateTime date { get; set; }
        public int income { get; set; }
        public int outcome {get; set;}

        public Cashboxs()
        {

        }
        public Cashboxs(DateTime date, int income, int outcome)
        {
            this.date = date;
            this.income = income;
            this.outcome = outcome;
        }
    }
}
