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
    /// </summary>m
    public sealed partial class Transactions : Page
    {
        private ObservableCollection<Transaction> transaction = new ObservableCollection<Transaction>();
         ObservableCollection<Transaction> Translist { get { return transaction; } }


        public Transactions()
        {
            this.InitializeComponent();
            ChoosenText.Text = MainPage.ChoosenAccount.AccountNumber;
            foreach(Transaction trans in MainPage.ChoosenAccount.TransactionList)
            {
                transaction.Add(trans);
            }
        }
        private void TransactionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        public async void PrintToFile()
        {
            Windows.Storage.StorageFolder storageFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
            await storageFolder.CreateFileAsync(MainPage.ChoosenAccount.AccountNumber + ".txt",
            Windows.Storage.CreationCollisionOption.ReplaceExisting);
            string result = "Transactioner:\n";
            foreach(Transaction trans in MainPage.ChoosenAccount.TransactionList)
            {
                result += trans.Summary;
            }
            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, result);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            PrintToFile();
            SaveToFile.IsEnabled = false;
          
           
        }
    }
}
