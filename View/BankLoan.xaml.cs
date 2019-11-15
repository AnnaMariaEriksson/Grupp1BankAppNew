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
	public sealed partial class BankLoan : Page
	{
		
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
			double amount = int.Parse(AmountToBorrowField.Text.ToString());
			int years = int.Parse(PaymentPeriodForLoanField.Text.ToString());
            int months = years * 12;
            double depth = amount * 0.2;
            amount = amount / months;
            amount = +depth;
			SumPerMonthToPayBack.Text = Math.Round(amount,3).ToString();
		}
	}
}
