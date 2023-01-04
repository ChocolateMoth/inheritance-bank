using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_bank
{
    class Account
    {
        private decimal _balance;
        public Account(decimal balance) 
        {
            Balance = balance;
        }
        public decimal Balance 
        {
            get { return _balance; }

            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    throw new Exception("cannot be negative");
                }
            }

        }
        public void Credit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;

            }
            else
            {
                throw new Exception("credit must be greater than zero");
            }
        }
        public  bool Debit(decimal amount)
        {
            bool Ok = true;
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                Ok = true;

            }
            else
            {
                Console.Write("debit exceeded balance");
                Ok = false;
            }
            return Ok;
        }
    }
}
