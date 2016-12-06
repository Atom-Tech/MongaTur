using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace MongaTur
{
    public class App : Application
    {
        public const string applicationURL = "http://mongaturwb.azurewebsites.net";
        public static MobileServiceClient client =
            new MobileServiceClient(applicationURL);

        public App()
        {
            MainPage = GetMainPage();
        }

        public static Page GetMainPage()
        {
            return new Home();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
