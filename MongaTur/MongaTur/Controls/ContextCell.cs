using MongaTur.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MongaTur
{
    public class ContextCell : ViewCell
    {
        public ContextCell()
        {
            var abrirMapa = new MenuItem() { Text = "Abrir Mapa" };
            abrirMapa.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            abrirMapa.Clicked += AbrirMapa_Clicked;
            ContextActions.Add(abrirMapa);
            if (Device.Idiom == TargetIdiom.Phone)
            {
                var telefonar = new MenuItem() { Text = "Telefonar" };
                telefonar.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                telefonar.Clicked += Telefonar_Clicked;
                ContextActions.Add(telefonar);
            }
        }

        private void Telefonar_Clicked(object sender, EventArgs e)
        {
            var menu = (MenuItem)sender;
            var lugar = (OndeFicar)menu.CommandParameter;
            DependencyService.Get<IDial>().Dial(lugar.Telefone);
        }

        private void AbrirMapa_Clicked(object sender, EventArgs e)
        {
            var menu = (MenuItem)sender;
            var lugar = (OndeFicar)menu.CommandParameter;
            Classes.Maps.AbrirMapa(lugar.Endereco);
        }
    }
}
