using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MongaTur
{
    public class Tela<T> : OnIdiom<T>
    {
        public T Desktop { get; set; }

        public static implicit operator T(Tela<T> onPlatform)
        {
            if (Device.Idiom == TargetIdiom.Desktop)
            {
                return onPlatform.Desktop;
            }

            return (OnIdiom<T>)onPlatform;
        }
    }
}
