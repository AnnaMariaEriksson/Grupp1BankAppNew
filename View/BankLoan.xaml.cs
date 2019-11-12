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
			
		}

		private void ApproveBankloanButton_Click(object sender, RoutedEventArgs e)
		{
			CustomerAccountInfoLabel.Text = "Lånet har beviljats!";
		}

		private void DoNotApproveBankloanButton_Click(object sender, RoutedEventArgs e)
		{
			CustomerAccountInfoLabel.Text = "Lånet har avslagits.";
		}

		private void AmountToBorrowField_TextChanged(object sender, TextChangedEventArgs e)
		{
			
		}

		private void CalculateSumButton_Click(object sender, RoutedEventArgs e)
		{
			int amount = int.Parse(AmountToBorrowField.Text);
			int years = int.Parse(PaymentPeriodForLoanField.Text);
			int sum = int.Parse(SumPerMonthToPayBack.Text);
			sum = years / amount / 12;
		}
	}
}
