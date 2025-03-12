using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace WiredBrainCoffee.CustomersApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
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
    }
}