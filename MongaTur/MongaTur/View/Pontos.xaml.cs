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
            viewModel = new PontosViewModel();
            viewModel.AddPonto(p);
        }

        private async void Pontos_OnAppearing(object sender, EventArgs e)
        {
            await viewModel.Select(p.Codigo);
            campoNome.Text = p.Nome;
            viewModel.Imagem = viewModel.Lista[0].LinkImagem;
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                viewModel.Imagem));
            foreach (var img in viewModel.Lista)
            {
                Image i = new Image()
                {
                    WidthRequest = 128,
                    HeightRequest = 128
                };
                i.Source = ImageSource.FromUri(
                    new Uri(img.LinkImagem));
                var tap = new TapGestureRecognizer();
                tap.Tapped += Tapped;
                i.GestureRecognizers.Add(tap);
                listaImagens.Children.Add(i);
            }
        }

        private void Tapped(object sender, EventArgs e)
        {
            var img = sender as Image;
            var imagem = img.Source as UriImageSource;
            viewModel.Imagem = imagem.Uri.AbsoluteUri;
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                viewModel.Imagem));
        }

        private void BotaoVoltar_OnClicked(object sender, EventArgs e)
        {
            var imagem = imagemExibida.Source as UriImageSource;
            string img = imagem.Uri.AbsoluteUri;
            int x = 0;
            for (int i = 0; i < viewModel.Lista.Count; i++)
            {
                var l = viewModel.Lista[i];
                if (l.LinkImagem == img)
                {
                    x = i;
                    break;
                }
            }
            if (x == 0)
            {
                x = viewModel.Lista.Count - 1;
            }
            else
            {
                x--;
            }
            viewModel.Imagem = viewModel.Lista[x].LinkImagem;
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                viewModel.Imagem));
        }

        private void BotaoAvancar_OnClicked(object sender, EventArgs e)
        {
            var imagem = imagemExibida.Source as UriImageSource;
            string img = imagem.Uri.AbsoluteUri;
            int x = 0;
            for (int i = 0; i < viewModel.Lista.Count; i++)
            {
                var l = viewModel.Lista[i];
                if (l.LinkImagem == img)
                {
                    x = i;
                    break;
                }
            }
            if (x == viewModel.Lista.Count - 1)
            {
                x = 0;
            }
            else
            {
                x++;
            }
            viewModel.Imagem = viewModel.Lista[x].LinkImagem;
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                viewModel.Imagem));
        }

        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var imagem = imagemExibida.Source as UriImageSource;
            await Navigation.PushAsync(new Imagem(imagem.Uri.AbsoluteUri,
                viewModel.Lista));
        }
    }
}