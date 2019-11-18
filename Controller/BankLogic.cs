using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Grupp1BankApp
{
	public class BankLogic
	{

        //	private static BankLogic instance;
        static List<Customer> customerList = new List<Customer>();
        public static int runOnce = 1;
        public BankLogic()
		{

       
      
            
        }

        public static void AddtocustomerList(Customer cust) {

            customerList.Add(cust);
        
        
        }


        //public static BankLogic Instance
        //{
        //	get { return instance ?? (instance = new BankLogic()); }
        //}



        public static Customer AddCustomer(string name, string SSN)
		{
            List<Account> accounts = new List<Account>();
            foreach (Customer cust in customerList)
            {
                if (cust.SSN == SSN)
                {
                    return null;
                }
            }
            Customer NyCustomer = new Customer(name, SSN);
            customerList.Add(NyCustomer);
			//PrintCustomerToFile.Print(customerList);
            return NyCustomer;
        }

		public static List<Customer> GetCustomers()
        {
            List<Customer> cust = customerList;
			
            return cust;
        }



		public static SavingsAcount AddSavingsAccount(Customer cust, string accountNumber)
		{

            List<Transaction> tempList = new List<Transaction>();
            //skapa ett objekt av savingsAccount
            SavingsAcount newAcc = new SavingsAcount(accountNumber, 0, 1, "saving",tempList,true);



            cust.CustomerAccounts.Add(newAcc);


            return newAcc;
		}  


        
        public static bool DepositMoney( Account account, double amount)
		{
            if (amount > 0)
            {
                account.Balance += amount;

                return true;
            }
            return false;
		}

        public static bool Withdraw(Account acc, double amount)
        {
            
            if (acc.AccountType == "saving")
            {
               
                if (amount > acc.Balance || amount < 0)
                {
                    return false;
                }

                if (acc.FirstWithDraw == true)
                {
                    acc.Balance -= amount;
                    acc.FirstWithDraw = false;
                }
               else if (acc.FirstWithDraw == false)
                {
                    //acc.Balance =  acc.Balance - (amount - (amount * 0.2));
                    double bal = amount / 100;
                    double balcalc = bal * 2;
                    double calc = amount * 0.2;
                    double calc2 = amount - calc;
                    acc.Balance = acc.Balance - balcalc;
                }
            }
            else if (acc.AccountType == "credit")
            {
                if (acc.Balance > -5000)
                {
                    CreditAccount acc2 = (CreditAccount)acc;
                    double bal = amount / 100;
                    double depth = bal * acc2.DeptRate;
                    acc.Balance -= amount + depth;

                }
            }
            return true;
                    
        }

        public static bool AddCreditAccount(string AccNumber,Customer cust)
        {
            List<Transaction> tempList = new List<Transaction>();

            CreditAccount NewAccount = new CreditAccount(0,5000, 0.5,7, AccNumber,"credit",tempList,true);
                cust.CustomerAccounts.Add(NewAccount);


            //try
            //{
            //    foreach (Account ac in cust.CustomerAccounts)
            //    {
            //        if (ac.AccountNumber == AccNumber)
            //        {
            //            cust.CustomerAccounts.Remove(NewAccount);
            //            return false;
            //        }


            //    }
            //}
            //catch (System.InvalidOperationException) { }


            return true;
            //TODO fix return statement.
        }

	}
}
