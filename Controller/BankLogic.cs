using System.Collections.Generic;
using System.Collections.ObjectModel;

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
			//TODO fix return statement.
		}

		public int AddSavingsAccount(long SSN)
		{
			return 0;
			//TODO fix return statement.
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
			//TODO fix return statement.
		}
        

		public bool Deposit(long SSN, int accountID, double amount)
		{
			return true;
			//TODO fix return statement.
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

		public int AddCreditAccount(long SSN)
		{
			return 0;
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