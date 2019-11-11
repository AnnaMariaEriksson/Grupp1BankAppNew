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
    public sealed partial class CreateAccount : Page
    {
        public CreateAccount()
        {
            this.InitializeComponent();
            Random rand = new Random();
            AccountNumber.Text = "4539 0310 " + rand.Next(1000, 10000).ToString() + " " + rand.Next(1000, 10000).ToString();
            SsnNumber.Text = MainPage.ChoosenCustomer.SSN;
            comboBox.Items.Add("Savings account");
            comboBox.Items.Add("Credit account");
            comboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool con = false;
            if(comboBox.SelectedItem.ToString() == "Savings account"){
                BankLogic.AddSavingsAccount(MainPage.ChoosenCustomer,AccountNumber.Text);
                con = true;
            }else if(comboBox.SelectedItem.ToString() == "Credit account")
            {
                BankLogic.AddCreditAccount(AccountNumber.Text, MainPage.ChoosenCustomer);
                con = true;

            }else if(comboBox.SelectedItem.ToString() == "")
            {
                con = false;
            }

            if (con == true)
            {
                var _Frame = Window.Current.Content as Frame;
                _Frame.Navigate(typeof(MainPage));
            }
            }
    }
}
