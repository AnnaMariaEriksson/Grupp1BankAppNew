using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Grupp1BankApp
{
	public class BankLogic
	{

        //	private static BankLogic instance;
        static List<Customer> customerList = new List<Customer>();
        static List<Account> accounts = new List<Account>();
        
        public BankLogic()
		{
       
            
        }

		public static bool AddCustomer(string name, string SSN)
		{


            
            foreach (Customer cust in customerList)
            {
                if (cust.SSN == SSN)
                {
                    return false;
                }
            }
            Customer NyCustomer = new Customer(name, SSN, accounts);
            customerList.Add(NyCustomer);
            return true;
        }

		

		public static List<Customer> GetCustomers()
		{
            List<Customer> cust = customerList;
            Customer anotherCustomer = new Customer("Pelle Karlsson", "19820505", accounts);
            customerList.Add(anotherCustomer);

			return cust;
		}


		public bool ChangeCustomerName(string name, long SSN)
		{
            MainPage.ChoosenCustomer.Name = name;

			return true;
		}



		public static SavingsAcount AddSavingsAccount(Customer cust, string accountNumber)
		{

            List<Transaction> tempList = new List<Transaction>();
            //skapa ett objekt av savingsAccount
            SavingsAcount newAcc = new SavingsAcount(accountNumber, 0, 1, "saving",tempList,true);



            cust.CustomerAccounts.Add(newAcc);


            return newAcc;
		}  


		public string GetAccount(Customer cust, string accountID)
		{
            string acc = null;
			foreach (Account ac in cust.CustomerAccounts)
            {
                if (accountID == ac.AccountNumber)
                {
                    acc =  ac.AccountNumber + " " + ac.Balance + " " + ac.InterestRate;
                    break;
                } 
            }
            return acc;
			
		}

        
        public static bool DepositMoney( Account account, double amount)
		{

            account.Balance += amount;

            return true;
		}

        public static bool Withdraw(Account acc, double amount)
        {
            if (acc.AccountType == "saving")
            {
               
                if (acc.Balance < amount)
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
                    acc.Balance -= amount * 0.2 - amount;
                }
            }
            else if (acc.AccountType == "credit")
            {
                if (acc.Balance > -5000)
                {
                    acc.Balance -= amount;

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