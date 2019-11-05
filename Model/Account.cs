using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public abstract class Account
    {

        public double interestRate;
        public double balance;
        public string accountNumber;
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public double InterestRate { get; set; }
        public List<Transactions> TransactionList { get; set; }

        List<Transactions> transactionList = new List<Transactions>();

        public Account(string accountNumber, double balance, double interestRate)
        {
            AccountNumber = accountNumber;  
            Balance = balance;  
            InterestRate = interestRate;   
        }
        
    }
    
}
