
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

       
        public static Customer ChoosenCustomer { get; set; }
        public static Account ChoosenAccount;
        public static int kebab = 5;
        public static Account ChoosenAccountObject;

        private ObservableCollection<Account> accounts = new ObservableCollection<Account>();
        ObservableCollection<Account> AcList { get { return accounts; } }


        public MainPage()
        {
            this.InitializeComponent();

            //test kund

            while (BankLogic.runOnce <= 1)
            {
                BankLogic.AddCustomer("Berit Nillson", "192304237494");
                BankLogic.AddSavingsAccount(BankLogic.GetCustomers().Find(customer => customer.SSN == "192304237494"), "12345");
                BankLogic.AddCreditAccount("1234", BankLogic.GetCustomers().Find(customer => customer.SSN == "192304237494"));

                BankLogic.runOnce++;
            }
            //

            MainFrame.Navigate(typeof(NotSelected_Page));

            foreach (Customer cust in BankLogic.GetCustomers()) {
                comboBox.Items.Add(cust.SSN);
            }
            try
            {
                Search_Field.Text = ChoosenCustomer.SSN;

            }
            catch (Exception) { }

            if (Search_Field != null)
            {
                try
                {
                    button_Click(null, null);
                }
                catch (Exception) { }
            }


        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Search_Field.Text != "" || comboBox.Text != "")
            {
                try
                {
                    accounts.Clear();
                    foreach (Account ac in accounts)
                    {
                        accounts.Remove(ac);
                    }
                }
                catch (InvalidOperationException)
                {

                }

                try
                {
                    ChoosenCustomer = BankLogic.GetCustomers().Find(cust => cust.SSN == Search_Field.Text);
                }
                catch (NullReferenceException) { }

                Fnamn.Text = ChoosenCustomer.Name;
                PersonNummer.Text = ChoosenCustomer.SSN;
                ChoosenCustomer.Name = Fnamn.Text;
                button.IsEnabled = false;
                try
                {
                    if (ChoosenCustomer.CustomerAccounts.Count != 0)
                    {
                        foreach (Account ac in ChoosenCustomer.CustomerAccounts)
                        {
                            accounts.Add(ac);
                        }
                    }
                    else
                    {
                        try { List<Transaction> emptytrans = new List<Transaction>(); Account empty = new SavingsAcount("Inget konto", 0, 0, "saving",emptytrans , false); AcList.Add(empty); } catch (Exception) { }
                    }
                }
                catch (System.NullReferenceException) { }
            }
            else { button.IsEnabled = false; }
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
            ChoosenCustomer = BankLogic.GetCustomers().Find(cust => cust.SSN == comboBox.Text);
            button.IsEnabled = true;
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

        private void Fnamn_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChoosenCustomer.Name = Fnamn.Text;
        }

    

        private void listView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChoosenAccount = (Account)listView.SelectedItem;
            MainFrame.Navigate(typeof(MainMeny));
        }
    }

}
