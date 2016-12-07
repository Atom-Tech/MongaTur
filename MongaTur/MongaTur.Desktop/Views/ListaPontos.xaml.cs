using MongaTur.Desktop.Models;
using MongaTur.Desktop.ViewModels;
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
        ListaPontosViewModel viewModel;

        public ListaPontos()
        {
            InitializeComponent();
            Loaded += ListaPontos_Loaded;
        }

        private async void ListaPontos_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = new ListaPontosViewModel();
            await viewModel.Select();
            lista.DataContext = viewModel;
        }
    }
}
