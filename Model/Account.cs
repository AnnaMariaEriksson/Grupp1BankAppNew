using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public abstract class Account
    {


        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public double InterestRate { get; set; }
        public List<Transaction> TransactionList { get; set; }

        List<Transaction> transactionList = new List<Transaction>();

        public Account(string accountNumber, double balance, double interestRate, string accountType)
        {
            AccountNumber = accountNumber;  
            Balance = balance;  
            InterestRate = interestRate;
            AccountType = accountType;
        }
        public string Summary
        {
            get { return AccountNumber + " Saldo:" + Balance; }
        }

    }
    
}
