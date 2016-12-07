using MongaTur.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MongaTur.View
{
    public partial class ListaLugarFicar : ContentPage
    {
        ListaLugarFicarViewModel viewModel =
            new ListaLugarFicarViewModel();

        public ListaLugarFicar()
        {
            InitializeComponent();
        }

        private async void ListaLugarFicar_OnAppearing(object sender, EventArgs e)
        {
            await viewModel.Select();
            Lista.ItemsSource = viewModel.Lista;
        }
        
    }
}
