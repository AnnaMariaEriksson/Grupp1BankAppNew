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
    public sealed partial class CreateCustomer : Page
    {
        public CreateCustomer()
        {
            this.InitializeComponent();
            textBlock.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankLogic.AddCustomer(NameText.Text, SsnText.Text);
            textBlock.Visibility = Visibility.Visible;
            var _Frame = Window.Current.Content as Frame;
            _Frame.Navigate(typeof(MainPage));
        }

        private void SsnText_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
            if (!args.Cancel && args.NewText.Length == 1 && SsnText.Text == "")
                sender.SelectionStart = args.NewText.Length + 1;
        }

        private void NameText_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => char.IsDigit(c));
            if (!args.Cancel && args.NewText.Length == 1 && NameText.Text == "")
                sender.SelectionStart = args.NewText.Length + 1;
        }
    }
}