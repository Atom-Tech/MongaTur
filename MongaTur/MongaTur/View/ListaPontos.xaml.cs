using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongaTur.ViewModels;
using Xamarin.Forms;

namespace MongaTur.View
{
    public partial class ListaPontos : ContentPage
    {
        private ListaPontosViewModel viewModel =
            new ListaPontosViewModel();
        PontosT p;

        public ListaPontos()
        {
            InitializeComponent();
            Lista.ItemSelected += Lista_ItemSelected;
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            p = (PontosT)e.SelectedItem;
            await Navigation.PushAsync(new Pontos(p));
        }
        
        private async void ListaPontos_OnAppearing(object sender, EventArgs e)
        {
            await viewModel.Select();
            Lista.ItemsSource = viewModel.Lista;
        }


    }
}
