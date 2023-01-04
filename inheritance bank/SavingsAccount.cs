using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_bank
{
    class SavingsAccount:Account
    {
        private decimal _interest;
        
        public SavingsAccount(decimal balance, decimal interest) : base(balance)
        {
            Interest = interest;
        }
        public decimal Interest
        {
            get { return _interest; }

            set
            {
                if (value > 0)
                {
                    _interest = value;
                }
                else
                {
                    throw new Exception("The intrest rate must be higher than zero");
                }
            }
        }
        public decimal CalInterest()
        {
            return Balance * Interest; 
        }
    }
}
