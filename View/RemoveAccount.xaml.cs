using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        object ChoosenAccount;
        private ObservableCollection<string> accounts = new ObservableCollection<string>();
        ObservableCollection<string> AcList { get { return accounts; } }
        public RemoveAccount()
		{
			this.InitializeComponent();

            foreach(Account ac in MainPage.ChoosenCustomer.CustomerAccounts)
            {
                accounts.Add(ac.AccountNumber);
            }

        }
        private void ListOfAccountsToRemove_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChoosenAccount = ListOfAccountsToRemove.SelectedItem;
        }

        private void RemoveAccountButton_Click(object sender, RoutedEventArgs e)
		{
            try
            {
                int ac = MainPage.ChoosenCustomer.CustomerAccounts.FindIndex(choosen => choosen.AccountNumber == ChoosenAccount.ToString());
                MainPage.ChoosenCustomer.CustomerAccounts.RemoveAt(ac);
                MainPage.RemoveMenyAccount(ac);
                accounts.Remove(ChoosenAccount.ToString());
            }
            catch (Exception) { }
        }

	


    }
}
