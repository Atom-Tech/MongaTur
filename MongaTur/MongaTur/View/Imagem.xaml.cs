using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongaTur.Model;
using Xamarin.Forms;

namespace MongaTur.View
{
    public partial class Imagem : ContentPage
    {
        private List<ImagensT> lista;

        public Imagem(string selecionado, List<ImagensT> lista)
        {
            InitializeComponent();
            this.lista = lista;
            imagemExibida.Source = ImageSource.FromUri(
                new Uri(selecionado));
        }
        private void BotaoVoltar_OnClicked(object sender, EventArgs e)
        {
            var imagem = imagemExibida.Source as UriImageSource;
            string img = imagem.Uri.AbsoluteUri;
            int x = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                var l = lista[i];
                if (l.LinkImagem == img)
                {
                    x = i;
                    break;
                }
            }
            if (x == 0)
            {
                x = lista.Count - 1;
            }
            else
            {
                x--;
            }
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                lista[x].LinkImagem));
        }

        private void BotaoAvancar_OnClicked(object sender, EventArgs e)
        {
            var imagem = imagemExibida.Source as UriImageSource;
            string img = imagem.Uri.AbsoluteUri;
            int x = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                var l = lista[i];
                if (l.LinkImagem == img)
                {
                    x = i;
                    break;
                }
            }
            if (x == lista.Count - 1)
            {
                x = 0;
            }
            else
            {
                x++;
            }
            imagemExibida.Source = ImageSource.FromUri(new Uri(
                lista[x].LinkImagem));
        }

    }
}
