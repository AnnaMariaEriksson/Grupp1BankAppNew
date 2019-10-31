using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Grupp1BankApp.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class RemoveAccount : Page
	{
		public BankLogic BankLogic { get; set; }
		public RemoveAccount()
		{
			this.InitializeComponent();
			BankLogic = new BankLogic();
		}

		public Customer MyCustomer { get; set; }

		private void RemoveAccountButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ListOfAccountsToRemove_ItemClick(object sender, ItemClickEventArgs e)
		{
			//ChosenAccountField.Text = ListOfAccountsToRemove.SelectedValue.ToString();
		}
	}
}
