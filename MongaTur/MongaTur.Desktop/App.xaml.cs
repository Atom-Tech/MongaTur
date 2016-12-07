using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MongaTur.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public const string applicationURL = "http://mongaturwb.azurewebsites.net";
        public static MobileServiceClient client =
            new MobileServiceClient(applicationURL);
    }
}
