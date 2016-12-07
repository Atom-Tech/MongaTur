using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MongaTur.Classes
{
    public static class Maps
    {
        public static void AbrirMapa(string address)
        {
            switch (Device.OS)
            {
                case TargetPlatform.iOS:
                    Device.OpenUri(
                      new Uri(string.Format("http://maps.apple.com/?q={0}",
                          WebUtility.UrlEncode(address))));
                    break;
                case TargetPlatform.Android:
                    Device.OpenUri(
                      new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode(address))));
                    break;
                case TargetPlatform.Windows:
                case TargetPlatform.WinPhone:
                    Device.OpenUri(
                     new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString(address))));
                    break;
            }
        }
    }
}
