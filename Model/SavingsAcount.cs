using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    class SavingsAcount : Account
    {
        public double saldo;
        public double räntesats;
        public int kontonummer;
       


        public SavingsAcount(string AccountNumber, double Balance, double InterestRate) : base(AccountNumber, Balance, InterestRate)
        {
       
        }
        

    }
}
