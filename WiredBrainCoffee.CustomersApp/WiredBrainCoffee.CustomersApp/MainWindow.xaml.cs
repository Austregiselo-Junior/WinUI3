using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WiredBrainCoffee.CustomersApp.ViewModel;

namespace WiredBrainCoffee.CustomersApp
{
    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; }

        public MainWindow(MainViewModel viewModel)
        {
            this.InitializeComponent();
            ViewModel = viewModel;
            root.Loaded += Root_Loaded;
        }

        private async void Root_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAsync();
        }

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            // var column = (int)custmerListGris.GetValue(Grid.ColumnProperty);, funciona mas temos que fazer um casting

            var column = Grid.GetColumn(custmerListGris); // pega o valor diretamente no grid e já retorna um int
            var newColumn = column == 0 ? 2 : 0;

            //  custmerListGris.SetValue(Grid.ColumnProperty, newColumn);, funciona mas temos que fazer um casting

            Grid.SetColumn(custmerListGris, newColumn);// pega o valor diretamente no grid e já retorna um int

            symbolIconMoveNavigation.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }

        private void ButtonToogleTheme_Click(object sender, RoutedEventArgs e)
        {
            root.RequestedTheme = root.RequestedTheme == ElementTheme.Light ? ElementTheme.Dark : ElementTheme.Light;
        }
    }
}