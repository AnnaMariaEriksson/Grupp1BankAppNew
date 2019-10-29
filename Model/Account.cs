using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }



        public Account(string accountNumber, double balance, double interestRate)
        {
            accountNumber = AccountNumber;
            balance = Balance;
            interestRate = InterestRate;
        }
        
    }
    
}
