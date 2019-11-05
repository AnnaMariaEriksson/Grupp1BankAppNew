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
        Account temp;
        public TransferMoney()
        {
        

            foreach (Account acc in MainPage.ChoosenCustomer.CustomerAccounts)
            {
                if (acc.AccountNumber == MainPage.ChoosenAccount)
                {
                    MainPage.ChoosenAccount = acc.AccountNumber;
                    temp = acc;

                }
            }

            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            temp.Balance -=double.Parse(textsum.Text);
            foreach(Account acc in MainPage.ChoosenCustomer.CustomerAccounts)
            {
                if(acc.AccountNumber == textbox2.Text)
                {
                    acc.Balance += double.Parse(textsum.Text);
                }
            }
        }
    }
}
