using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MongaTur
{
    public partial class Home : MasterDetailPage
    {
        Navi navi;

        public Home()
        {
            InitializeComponent();
            navi = (Navi)Master;
            navi.ListaNavi.ItemSelected += ListaNavi_ItemSelected;
        }

        private void ListaNavi_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Pagina));
                navi.ListaNavi.SelectedItem = null;
                IsPresented = false;
            }
        }
        
    }
}
