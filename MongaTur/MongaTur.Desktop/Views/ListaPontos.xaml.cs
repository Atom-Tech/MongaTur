using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MongaTur.Desktop.Views
{
    /// <summary>
    /// Interaction logic for ListaPontos.xaml
    /// </summary>
    public partial class ListaPontos : Page
    {

        public ListaPontos()
        {
            InitializeComponent();
            Loaded += ListaPontos_Loaded;
        }

        private async void ListaPontos_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel =
                new ViewModels.ListaPontosViewModel();
            await viewModel.Select();
            lista.DataContext = viewModel;
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ponto = (PontosT)lista.SelectedItem;
        }
    }
}
