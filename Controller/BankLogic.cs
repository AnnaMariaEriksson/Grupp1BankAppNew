using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Grupp1BankApp
{
	public class BankLogic
	{

        //	private static BankLogic instance;
        static List<Customer> customerList = new List<Customer>();
        public static List<Account> accounts = new List<Account>();
        
        public BankLogic()
		{
       
            
        }
       
      


        //public static BankLogic Instance
        //{
        //	get { return instance ?? (instance = new BankLogic()); }
        //}

     

		public static bool AddCustomer(string name, string SSN)
		{
            Customer NyCustomer = new Customer(name, SSN, accounts);
            customerList.Add(NyCustomer); 

            if  (NyCustomer.SSN == SSN)
            {
                return false;
            }

            else
            {
                return true;
            }

            
        }

		

		public static List<Customer> GetCustomers()
		{
            List<Customer> cust = customerList;

			return cust;
		}

		public List<string> GetCustomer(long SSN)
		{
			List<string> customers = new List<string>();

			return customers;
			//TODO fix return statement.
		}

		public bool ChangeCustomerName(string name, long SSN)
		{
            MainPage.ChoosenCustomer.Name = name;

			return true;
			//TODO fix return statement.
		}

		public List<string> RemoveCustomer(long SSN)
		{
			List<string> removedCustomers = new List<string>();
			return removedCustomers;
		
		}

		public int AddSavingsAccount(long SSN)
		{



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

        
        public static bool DepositMoney( string account, double amount)
		{
            
           List<Account> accountlist = MainPage.ChoosenCustomer.CustomerAccounts;

            Account SearchChoosenAccount = accountlist.FirstOrDefault(choosen => choosen.AccountNumber == account);

            SearchChoosenAccount.Balance += amount;
              
           

            return true;
			
		}

		public bool Withdraw(long SSN, int accountID, double amount)
		{
			return true;
			//TODO Fix return statement.
		}

		public string CloseAccount(long SSN, int accountID)
		{
			return "";
			//TODO fix return statement.
		}

        public static bool AddCreditAccount(string AccNumber,Customer cust)
        {
            
              //  Account NewAccount = new Account(AccNumber, 0, 0.5);
                //cust.CustomerAccounts.Add(NewAccount);


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


		public List<string> GetTransactions(long SSN, int accountID)
		{
			List<string> transactionList = new List<string>();

			return transactionList;
			//TODO fix return statement.
		}
	}
}