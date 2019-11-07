using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public class Transaction
    {
        public string AccountID
        { get; set; }

        public DateTime Date
        { get; set; }


        public double Amount
        { get; set; }

        public double Balance
        { get; set; }

        public Transaction(string accountID, DateTime date, double amount, double balance)
        {
            AccountID = accountID;
            Date = date;
            Amount = amount;
            Balance = balance;
        }
        public string Summary
        {
           get { return Date + " Överfört: " + Amount + " Saldo: " + Balance; }   
        }
    }
}
