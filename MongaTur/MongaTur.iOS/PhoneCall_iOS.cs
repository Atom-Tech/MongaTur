using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace MongaTur.iOS
{
    public class PhoneCall_iOS : IDial
    {
        public void Dial(string numero)
        {
            UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + numero));
        }
    }
}
