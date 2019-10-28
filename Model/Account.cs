using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public class Account
    {
        public enum accountType { }
        public string accountNumber;
        public double balance;
        public double interestRate;

        public Account(string AccountNumber, double Balance, double InterestRate)
        {
            accountNumber = AccountNumber;
            balance = Balance;
            interestRate = InterestRate;
        }
    }
}
