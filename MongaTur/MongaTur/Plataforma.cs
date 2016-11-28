using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MongaTur
{
    public class Plataforma<T> : OnPlatform<T>
    {
        public T Windows { get; set; }

        public static implicit operator T(Plataforma<T> onPlatform)
        {
            if (Device.OS == TargetPlatform.Windows)
            {
                return onPlatform.Windows;
            }

            return (OnPlatform<T>)onPlatform;
        }
    }
}
