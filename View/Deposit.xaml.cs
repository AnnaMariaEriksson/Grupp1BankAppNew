﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
    public sealed partial class Deposit : Page
    {
      
        public Deposit()
        {
            this.InitializeComponent();
            ChoosenAccText.Text = MainPage.ChoosenAccount.AccountNumber;
            sumValue.Visibility = Visibility.Collapsed;
            sumText.Visibility = Visibility.Collapsed;
             
            Balance_Text.Text = MainPage.ChoosenAccount.Balance.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
           
            BankLogic.DepositMoney(MainPage.ChoosenAccount, double.Parse(sum.Text));
            Transaction transnew = new Transaction(MainPage.ChoosenAccount.AccountNumber, DateTime.Now, double.Parse(sum.Text), MainPage.ChoosenAccount.Balance);
            sumValue.Text = sum.Text;
            sumValue.Visibility = Visibility.Visible;
            sumText.Visibility = Visibility.Visible;
            
            MainPage.ChoosenAccount.TransactionList.Add(transnew);
            this.Frame.Navigate(typeof(MainMeny));
            //Thread.Sleep(2000);
        }

        private void sum_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
    }
}