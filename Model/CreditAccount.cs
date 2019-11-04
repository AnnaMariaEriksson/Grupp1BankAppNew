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

        double balance;
        int creditLimit;
        double interestRate;
        double deptRate;
        string accountNumber;

        //Construktor
        public CreditAccount(double balance, int creditLimit, double interestRate, double deptRate, string accountNumber)
            : base (accountNumber, balance, interestRate)
        {
            this.balance = balance;
            this.creditLimit = creditLimit;
            this.interestRate = interestRate;
            this.deptRate = deptRate;
            this.accountNumber = accountNumber;
        }


        //get-set metoder
        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

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

        public double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                interestRate = value;
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

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        }



        enum accountType { };

    }
}
