using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    
    class Transactions
    {
        private string accountID;
        private DateTime date;
        private Enum transactionsType;
        private double amount;
        private double balance;
        public Transactions(string AccountID, DateTime Date, Enum TransactionsType, double Amount, double Balance)
        {
            accountID = AccountID;
            date = Date;
            transactionsType = TransactionsType;
            amount = Amount;
            balance = Balance;
        }
    }
}
