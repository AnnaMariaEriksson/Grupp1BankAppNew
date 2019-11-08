using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    public class SavingsAcount : Account
    {
       

        public SavingsAcount(string accountNumber, double balance, double InterestRate, string accountType, List<Transaction> translist)
            : base(accountNumber, balance, InterestRate, accountType, translist)
        {
           
        }

      




    }
}
