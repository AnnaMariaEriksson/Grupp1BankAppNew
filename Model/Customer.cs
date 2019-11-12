 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1BankApp
{
	[Serializable]
    public class Customer
    {
        public List<Account> CustomerAccounts = new List<Account>();
        public string Name { get; set; }
        public string SSN { get; set; }

        public Customer(string name, string ssn)
        {
	        Name = name;
	        SSN = ssn;
        }
    }
}
