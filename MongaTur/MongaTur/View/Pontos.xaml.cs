using MongaTur.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MongaTur.View
{
    public partial class Pontos : ContentPage
    {
        ImagemManager manager;
        PontosT p;
        ObservableCollection<ImagensT> lista;

        public Pontos()
        {
            InitializeComponent();
            manager = new ImagemManager();
            p = Main.p;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshItems(true, syncItems: true);
        }

        private async Task RefreshItems(bool showActivityIndicator, bool syncItems)
        {
            using (var scope = new ActivityIndicatorScope(syncIndicator, showActivityIndicator))
            {
                lista = await manager.GetTodoItemsAsync(syncItems);
                imagem.Source = lista[0].LinkImagem;
            }
        }

        public async Task<List<ImagensT>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(Constants.ApplicationURL+
                    "/tables/imagensT");
                var imagens = JsonConvert.DeserializeObject
                    <List<ImagensT>>(json);
                return imagens;
            }
        }

        private class ActivityIndicatorScope : IDisposable
        {
            private bool showIndicator;
            private ActivityIndicator indicator;
            private Task indicatorDelay;

            public ActivityIndicatorScope(ActivityIndicator indicator, bool showIndicator)
            {
                this.indicator = indicator;
                this.showIndicator = showIndicator;

                if (showIndicator)
                {
                    indicatorDelay = Task.Delay(2000);
                    SetIndicatorActivity(true);
                }
                else
                {
                    indicatorDelay = Task.FromResult(0);
                }
            }

            private void SetIndicatorActivity(bool isActive)
            {
                this.indicator.IsVisible = isActive;
                this.indicator.IsRunning = isActive;
            }

            public void Dispose()
            {
                if (showIndicator)
                {
                    indicatorDelay.ContinueWith(t => SetIndicatorActivity(false), TaskScheduler.FromCurrentSynchronizationContext());
                }
            }

        }
    }
}