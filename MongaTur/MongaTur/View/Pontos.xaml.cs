using MongaTur.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MongaTur.ViewModels;
using Xamarin.Forms;

namespace MongaTur.View
{
    public partial class Pontos : ContentPage
    {
        private PontosViewModel viewModel;
        PontosT p;
        
        public Pontos(PontosT p)
        {
            InitializeComponent();
            this.p = p;
            viewModel = new PontosViewModel(p);
            BindingContext = viewModel;
        }

        private async void Pontos_OnAppearing(object sender, EventArgs e)
        {
            await viewModel.Select(p.Codigo);
            Lista.ItemsSource = viewModel.Lista;
        }
    }
}