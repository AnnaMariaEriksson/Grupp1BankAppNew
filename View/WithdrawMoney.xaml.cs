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
            Transaction transnew = new Transaction(MainPage.ChoosenAccount.AccountNumber, DateTime.Now, double.Parse(Textsum.Text), MainPage.ChoosenAccount.Balance);


            if (BankLogic.Withdraw(MainPage.ChoosenAccount, double.Parse(Textsum.Text)) == true)
            {
                MainPage.ChoosenAccount.TransactionList.Add(transnew);
            }
            this.Frame.Navigate(typeof(MainMeny));
        }

        private void Textsum_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
    }
}
