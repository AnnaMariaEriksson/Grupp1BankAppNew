using System.Collections.Generic;
using System.IO;

namespace Grupp1BankApp
{

	public class PrintCustomerToFile
	{
		private Customer customer;

		public static void Print(List<Customer> customersList)
		{
			string path = "C:\\Users\\anna-\\source\\repos\\Bank\\Customers.txt";

			using (StreamWriter writer = new StreamWriter(path, true))
			{
				foreach (Customer customer in customersList)
				{
					writer.WriteLine($"{customer.Name}, {customer.SSN}");
				}
			}
		}
	}
}