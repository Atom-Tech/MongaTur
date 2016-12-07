using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MongaTur.Droid
{
    public class PhoneCall_Droid : IDial
    {
        public void Dial(string numero)
        {
            var uri = Android.Net.Uri.Parse(string.Format("tel:{0}",numero));
            var intent = new Intent(Intent.ActionCall, uri);
            Xamarin.Forms.Forms.Context.StartActivity(intent);
        }
    }
}