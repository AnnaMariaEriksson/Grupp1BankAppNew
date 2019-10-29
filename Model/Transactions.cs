using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    
    class Transactions
    {
        public Transactions(string AccountID, DateTime Date, Enum TransactionsType, double Amount, double Balance)
        {
            accountID = AccountID;
            date = Date;
            transactionsType = TransactionsType;
            amount = Amount;
            balance = Balance;
        }

        public string accountID
            { get; set; }

        public DateTime date
            { get; set; }

        public Enum transactionsType 
            { get; set; }

        public double amount
            { get; set; }

        public double balance
            { get; set; }
    }
}
