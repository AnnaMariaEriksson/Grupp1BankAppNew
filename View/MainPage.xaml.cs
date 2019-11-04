
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

      public static  Customer ChoosenCustomer;
        public static string ChoosenAccount;
        public static int kebab = 5;
        public static Account ChoosenAccountObject;



        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(NotSelected_Page));

            foreach (Customer cust in BankLogic.GetCustomers()) {
                comboBox.Items.Add(cust.SSN);
                    }

           
    }

        
        private void button_Click(object sender, RoutedEventArgs e)
        {

            

            listView.Items.Clear();
            List<Customer> customerlist = BankLogic.GetCustomers();
            foreach(Customer cust in customerlist)
            {
                if(cust.SSN == Search_Field.Text)
                {
                    Fnamn.Text = cust.Name;
                    PersonNummer.Text = cust.SSN;
                    ChoosenCustomer = cust;
                    foreach (Account ac in cust.CustomerAccounts)
                    {
                        try
                        {
                            listView.Items.Add(ac.AccountNumber );

                         
                            



                        }
                        catch (ArgumentException) { }
                    }
                }
                else
                {
                    listView.Items.Add("Inget konto");
                }
            }
           
            




           
            
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                List<Account> accountlist = MainPage.ChoosenCustomer.CustomerAccounts;
                ChoosenAccount = listView.SelectedItems[0].ToString();
                ChoosenAccountObject = accountlist.FirstOrDefault(choosen => choosen.AccountNumber == ChoosenAccount);
               



            }
            catch (NullReferenceException) { }
           // test = (Account)sender;            
            MainFrame.Navigate(typeof(MainMeny));
        }

        private void addCustomer_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(CreateCustomer));
        }

        private void Ssn_Selected(object sender, SelectionChangedEventArgs e)
        {
            Search_Field.Text = comboBox.Text;
        }

        private void addCustomer_button_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(CreateAccount));
        }

        private void RemoveCustomer_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(RemoveAccount));
        }
    }
}
