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

namespace Grupp1BankApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Transactions : Page
    {
        private ObservableCollection<Transaction> transaction = new ObservableCollection<Transaction>();
        public Transactions()
        {
            this.InitializeComponent();
        }
        private void TransactionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(Account acc in MainPage.ChoosenCustomer.CustomerAccounts)
            {
                if(acc.AccountNumber == MainPage.ChoosenAccount.AccountNumber)
                {
                   foreach(Transaction trans in acc.TransactionList)
                    {
                       transaction.Add(trans);
                    }
                }
            }
        }
    }
}
