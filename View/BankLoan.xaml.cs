﻿using System;
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
	public sealed partial class BankLoan : Page
	{
        public double amount;
		public BankLoan()
		{
			this.InitializeComponent();
			//CustomerAccountInfoLabel.Text = MainPage.ChoosenAccount.Summary;
			SumPerMonthToPayBack.Text = "Fyll i summa du vill låna och antal år och tryck sen på beräkna.";

		}

		private void AmountToBorrowField_TextChanged(object sender, TextChangedEventArgs e)
		{
			
		}

		private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
		{
            
			double amount1 = int.Parse(AmountToBorrowField.Text.ToString());
			double years = int.Parse(PaymentPeriodForLoanField.Text.ToString());
            if (amount1 > 0)
            {
                amount = amount1;
                double amount2 = amount1;
                amount2 = amount2 / years;//10000 1 år
                double depth = amount2 / 12;//833 per månad
                amount2 = amount2 / 12 * 0.02; // ränta på 833
                double newamount = depth + amount2;
                SumPerMonthToPayBack.Text = newamount.ToString();
            }
		}

        private void LoanClick(object sender, RoutedEventArgs e)
        {
           
            if (amount > 0)
            {
                MainPage.ChoosenAccount.Balance += amount;
                Transaction transnew = new Transaction(MainPage.ChoosenAccount.AccountNumber, DateTime.Now, amount, MainPage.ChoosenAccount.Balance);
                MainPage.ChoosenAccount.TransactionList.Add(transnew);
                this.Frame.Navigate(typeof(MainMeny));
            }
        }

        private void AmountToBorrowField_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }

        private void PaymentPeriodForLoanField_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
    }
}
