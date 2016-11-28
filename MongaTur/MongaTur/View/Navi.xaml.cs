using MongaTur.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongaTur.ViewModels;
using Xamarin.Forms;

namespace MongaTur
{
    public partial class Navi : ContentPage
    {

        public ListView ListaNavi
        {
            get { return listView; }
        }

        public Navi()
        {
            InitializeComponent();
            var masterPageItems = NaviViewModel.MenuItems();
            listView.ItemsSource = masterPageItems;
        }
    }
}
