using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    internal class BankTransaktion
    {
        private DateTime dateTransaktion;
        private decimal amount;
        public BankTransaktion(decimal amount)
        {
            this.amount = amount;
            dateTransaktion = DateTime.Now;
        }
        public DateTime TransaktionDate
        {
            get
            {
                return dateTransaktion;
            }
        }
        public decimal TransaktionAmount
        {
            get
            {
                return amount;
            }
        }
    }
}
