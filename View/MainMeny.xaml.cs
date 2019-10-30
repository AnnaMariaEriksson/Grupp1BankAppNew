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
    public sealed partial class MainMeny : Page
    {
        public MainMeny()
        {
            this.InitializeComponent();
        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Deposit));


        }

        private void transactions_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Transactions));
        }

        private void transfer_button_Click(object sender, RoutedEventArgs e)
        {
          //  this.Frame.Navigate(typeof());
        }

        private void remove_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RemoveAccount));
        }
    }
}
