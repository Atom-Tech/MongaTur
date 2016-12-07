using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Calls;

namespace MongaTur.WinPhone
{
    public class PhoneDial_WinPhone : IDial
    {
        public void Dial(string numero)
        {
            PhoneCallManager.ShowPhoneCallUI
                (numero, "");
        }
    }
}
