using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{

    public class Customer
    {
        public List<Account> CustomerAccounts = new List<Account>();
        private string name;
        private string ssn;

        public Customer(string Name, string Ssn, List<Account> accounts)
        {
            name = Name;
            ssn = Ssn;
        }

        

        public string GetSSn { get; set; }
        


        public string GetName { get; set; }

        public List<Account> GetAccounts { get; set; }

        

        






    }
}
