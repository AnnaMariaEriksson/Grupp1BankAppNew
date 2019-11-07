using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    
   public class Transaction
    {
        public Transaction(string AccountID, DateTime Date, double Amount, double Balance)
        {
            accountID = AccountID;
            date = Date;
            amount = Amount;
            balance = Balance;
        }

        public string accountID
            { get; set; }

        public DateTime date
            { get; set; }


        public double amount
            { get; set; }

        public double balance
            { get; set; }
    }
}
