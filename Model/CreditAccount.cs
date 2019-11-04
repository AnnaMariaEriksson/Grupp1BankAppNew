using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
    class CreditAccount : Account
    {
        // Attributen i CreditAccount klassen
        int creditLimit;      
        double deptRate;
        string accountType;
        

        //Construktor
        public CreditAccount(double balance, int creditLimit, double interestRate, double deptRate, string accountNumber, string accountType)
            : base (accountNumber, balance, interestRate)
        {

            this.creditLimit = creditLimit;
            this.deptRate = deptRate;
            this.accountType = accountType;
        }


        //get-set metoder
        public int CeditLimit
        {
            get
            {
                return creditLimit;
            }

            set
            {
                creditLimit = value;
            }
        }

        public double DeptRate
        {
            get
            {
                return deptRate;
            }

            set
            {
                deptRate = value;
            }
        }

        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }






    }
}
