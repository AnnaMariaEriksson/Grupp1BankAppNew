using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public class SavingsAcount : Account
    {
        bool firstWithDraw;

        public SavingsAcount(string accountNumber, double balance, double InterestRate, string accountType)
            : base(accountNumber, balance, InterestRate, accountType)
        {
            this.firstWithDraw = false;
        }

        public bool FirstWithDraw { get; set; }




    }
}
