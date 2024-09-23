using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatagridTut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaProdotti lista = new ListaProdotti();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = lista;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = MiaGrid.ItemContainerGenerator.ContainerFromItem((sender as Button).DataContext) as DataGridRow;
            if (row != null)
            {
                Prodotto prodotto = row.DataContext as Prodotto;
                MessageBox.Show("Il prezzo di " + prodotto.Nome + " è " + prodotto.Prezzo);
            }

        }

        private void btnPrezzo_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var row = MiaGrid.ItemContainerGenerator.ContainerFromItem(button.DataContext) as DataGridRow;

            if (row != null)
            {
                Prodotto prodotto = row.DataContext as Prodotto;
                if (prodotto != null)
                {
                    MessageBox.Show("Il prezzo di " + prodotto.Nome + " è " + prodotto.Prezzo);
                }
            }
        }

    }
}
