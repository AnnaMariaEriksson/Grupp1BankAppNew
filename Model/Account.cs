﻿using System;
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
        public bool firstWithDraw = true;
        public double InterestRate { get; set; }
        public List<Transaction> TransactionList { get; set; }

       

        public Account(string accountNumber, double balance, double interestRate, string accountType,List<Transaction> translist, bool firstwithraw)
        {
            AccountNumber = accountNumber;  
            Balance = balance;  
            InterestRate = interestRate;
            AccountType = accountType;
            TransactionList = translist;
            this.firstWithDraw = firstwithraw;
        }

        public bool FirstWithDraw
        {
            get { return firstWithDraw; }
            set { firstWithDraw = value; }
        }
        public string Summary
        {
            get { return AccountNumber + "     " + Balance ; }

        }

        public string AccSummary
        {
            get { return AccountNumber + " " + AccountType; }
        }

    }
    
}
