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


		public bool ChangeCustomerName(string name, long SSN)
		{
            MainPage.ChoosenCustomer.Name = name;

			return true;
		}



		public SavingsAcount AddSavingsAccount(Customer cust, string accountNumber)
		{

            
            SavingsAcount newAcc = new SavingsAcount(accountNumber, 0, 1, "saving");


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

        public bool Withdraw(Account acc, SavingsAcount FirstWithDraw, double amount)
        {
            if (acc.AccountType == "saving")
            {
                if (acc.Balance < amount)
                {
                    return false;
                }

                else if (FirstWithDraw.FirstWithDraw == false)
                {
                    acc.Balance -= amount;
                }

                else if (FirstWithDraw.FirstWithDraw == true)
                {
                    acc.Balance -= amount * 0.2 - amount;
                }
            }

            else if (acc.Balance <= -5000)

                acc.Balance -= amount;

            return true;
                    
        }

        public static bool AddCreditAccount(string AccNumber,Customer cust)
        {
            
                CreditAccount NewAccount = new CreditAccount(0,5000, 0.5,7, AccNumber,"");
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