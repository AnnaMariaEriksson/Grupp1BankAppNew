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
    public sealed partial class TransferMoney : Page
    {
       // Account temp;
        public TransferMoney()
        {
        

            //foreach (Account acc in MainPage.ChoosenCustomer.CustomerAccounts)
            //{
            //    if (acc.AccountNumber == MainPage.ChoosenAccount.AccountNumber)
            //    {
            //        MainPage.ChoosenAccount = acc;
            //        temp = acc;

            //    }
            //}
         
            this.InitializeComponent();
            YourAccountText.Text = MainPage.ChoosenAccount.AccountNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.ChoosenAccount.Balance >= double.Parse(textsum.Text))
            {
                MainPage.ChoosenAccount.Balance -= double.Parse(textsum.Text);

                foreach (Account acc in MainPage.ChoosenCustomer.CustomerAccounts)
                {
                    if (acc.AccountNumber == textbox2.Text)
                    {
                        acc.Balance += double.Parse(textsum.Text);
                        
                        Transaction transnew = new Transaction(MainPage.ChoosenAccount.AccountNumber, DateTime.Now, double.Parse(textsum.Text), MainPage.ChoosenAccount.Balance);
                        acc.TransactionList.Add(transnew);
                        MainPage.ChoosenAccount.TransactionList.Add(transnew);
                    }
                }

            }
           

          
            var _Frame = Window.Current.Content as Frame;
            _Frame.Navigate(typeof(MainPage));
        }
    }
}
