using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_bank
{
    class CheckingAccount:Account
    {
        private decimal _fee;
        public CheckingAccount(decimal balance,decimal fee) : base(balance)
        {
            Fee = fee;

        }
        public decimal Fee
        {
            get { return _fee; }

            set//take code from account
            {
                if (value >= 0)
                {
                    _fee = value;
                }
                else
                {
                    throw new Exception("fee cannot be negative");
                }
            }
        }
        public new void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance-= Fee;
        }
        public new bool Debit(decimal amount)
        {
            if(base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }

    }
}
