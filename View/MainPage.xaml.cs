
using Grupp1BankApp.View;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Grupp1BankApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {

        public static  Customer ChoosenCustomer;
        public static Account ChoosenAccount;
        public static int kebab = 5;
        public static Account ChoosenAccountObject;

        private ObservableCollection<Account> accounts = new ObservableCollection<Account>();
        ObservableCollection<Account> AcList { get { return accounts; } }


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
            try
            {
                foreach (Account ac in accounts)
                {
                    accounts.Remove(ac);
                }
            }
            catch (InvalidOperationException) {
               
            }
                List<Customer> customerlist = BankLogic.GetCustomers();
            foreach(Customer cust in customerlist)
            {
                if(cust.SSN == Search_Field.Text)
                {
                    Fnamn.Text = cust.Name;
                    PersonNummer.Text = cust.SSN;
                    ChoosenCustomer = cust;

                    try
                    {
                        foreach (Account ac in ChoosenCustomer.CustomerAccounts)
                        {
                            accounts.Add(ac);
                        }
                    }
                    catch (System.NullReferenceException) { }


                }
                else
                {
                    listView.Items.Add("Inget konto");
                }
            }



            ChoosenCustomer.Name = Fnamn.Text;


           
            
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                List<Account> accountlist = MainPage.ChoosenCustomer.CustomerAccounts;
                try
                {
                    ChoosenAccount = (Account)listView.SelectedItem;
                 //   ChoosenAccountObject = accountlist.FirstOrDefault(choosen => choosen.AccountNumber == ChoosenAccount);
                }
                catch (System.Runtime.InteropServices.COMException) { }
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
            try
            {
                MainFrame.Navigate(typeof(CreateAccount));
            }
            catch (Exception) { }
        }

        private void RemoveCustomer_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainFrame.Navigate(typeof(RemoveAccount));
            }
            catch (Exception) { }
        }

        private void Search_Field_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c =>!char.IsDigit(c));
        }

        private void Fnamn_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            
        }

        private void Fnamn_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChoosenCustomer.Name = Fnamn.Text;
        }
    }
}
