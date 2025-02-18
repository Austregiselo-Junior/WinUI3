using Microsoft.UI.Xaml;

namespace WiredBrainCoffee.CustomersApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ButtonAddCustmer_Click(object sender, RoutedEventArgs e)
        {
            btnAddCustmer.Content = "Client added!";
        }
    }
}