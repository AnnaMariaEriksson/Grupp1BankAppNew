
using Grupp1BankApp.View;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Grupp1BankApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        List<Account> accounts = new List<Account>();
        public static string ChoosenAccount;
        public static int kebab = 5;
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(NotSelected_Page));
            accounts.Add(Account.ac1);
            accounts.Add(Account.ac2);
            accounts.Add(Account.ac3);




        }

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            //  MainFrame.Navigate(typeof(MainMeny));
            foreach (Account ac in accounts)
            {
                try
                {
                    listView.Items.Add(ac.AccountNumber);
                }
                catch (ArgumentException) { }
            }
            
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           ChoosenAccount = listView.SelectedItem.ToString();
           // test = (Account)sender;            
            MainFrame.Navigate(typeof(MainMeny));
        }
    }
}
