using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Grupp1BankApp
{
	public class BankLogic
	{

        //	private static BankLogic instance;
       static List<Customer> customerList = new List<Customer>();
        public static List<Account> accounts = new List<Account>();
        public static Account ac1 = new Account("4535352644", 55, 55);
        public static Account ac2 = new Account("456987866644", 55, 55);
        public static Account ac3 = new Account("45986554644", 55, 55);
        private BankLogic()
		{
       
            
        }

        //public static BankLogic Instance
        //{
        //	get { return instance ?? (instance = new BankLogic()); }
        //}

     

		public static bool AddCustomer()
		{
			return true;
			//TODO fix return statement.
		}

		public static void CreateCustomer()
		{
            accounts.Add(ac1);
            accounts.Add(ac2);
            accounts.Add(ac3);
            Customer NyCustomer = new Customer("Pelle", "432452234", accounts);
            customerList.Add(NyCustomer);
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

		public string GetAccount(string SSN, int accountID)
		{
			return "";
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