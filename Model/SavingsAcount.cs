using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    class SavingsAcount : Account
    {
        public string accountType;

        public SavingsAcount(string accountNumber, double balance, double InterestRate, string accountType)
            : base(accountNumber, balance, InterestRate)
        {
            this.accountType = accountType;
        }

        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }

    }
}
