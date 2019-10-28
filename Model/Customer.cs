using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{

    class Account { }

   abstract class Customer
   {
        public List<Account> CustomerAccounts = new List<Account>();
        private string name;
        private string ssn;
        
        public Customer(string Name, string Ssn)
        {
            name = Name;
            ssn = Ssn;
        }

 
   


   }
}
