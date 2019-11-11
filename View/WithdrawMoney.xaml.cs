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
    public sealed partial class WithdrawMoney : Page
    {
        public WithdrawMoney()
        {
            this.InitializeComponent();
            choosentext.Text = MainPage.ChoosenAccount.AccountNumber;
            balanceText.Text = MainPage.ChoosenAccount.Balance.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankLogic.Withdraw(MainPage.ChoosenAccount, double.Parse(Textsum.Text));
            if(MainPage.ChoosenAccount.Balance > -5000)
            {
                Transaction transnew = new Transaction(MainPage.ChoosenAccount.AccountNumber, DateTime.Now, double.Parse(Textsum.Text), MainPage.ChoosenAccount.Balance);
                MainPage.ChoosenAccount.TransactionList.Add(transnew);
            }
          
            var _Frame = Window.Current.Content as Frame;
            _Frame.Navigate(typeof(MainPage));
        }
    }
}
