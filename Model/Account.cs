using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public class Account
    {
        public  string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

       public static Account ac1 = new Account("4535352644", 55, 55);
        public static Account ac2 = new Account("456987866644", 55, 55);
        public static Account ac3 = new Account("45986554644", 55, 55);
        public Account(string accountNumber, double balance, double interestRate)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            InterestRate = interestRate;
        }
        
    }
    
}
