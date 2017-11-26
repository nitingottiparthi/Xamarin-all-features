using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using System.Net;

namespace MyFirstPcl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMapPage : ContentPage
    {
        Map map = new Map();

        //public Page1()
        //{
        //    //InitializeComponent();
        //    InitializeComponent();
        //    try
        //    {
        //        Position position = new Position(17.63517, 78.34232);
        //        Pin pin = new Pin();
        //        pin.Position = position;
        //        pin.Label = "Hyderabad";
        //        map.Pins.Add(pin);
        //        this.Content = map;
        //        //GetLatLongs();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        public MyMapPage()
        {
            InitializeComponent();
            Position position = new Position(17.63517,78.34232);
            Pin pin = new Pin();
            pin.Position = position;
            map.Pins.Add(pin);
            List<Pin> pins = (List<Pin>)map.Pins;
            this.Content = map;
            char value = 'a';
           ////// switch (Device.OS)
           ////// {
           ////     case TargetPlatform.iOS:
                  //Device.OpenUri( new Uri(string.Format("http://maps.apple.com/?q={0}", WebUtility.UrlEncode(entryName.Text))));
           ////         break;
           ////     case TargetPlatform.Android:
           ////         Device.OpenUri(
           ////             new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode(entryName.Text))));
           ////         break;
           ////     case TargetPlatform.Windows:
           ////     case TargetPlatform.WinPhone:
           ////         Device.OpenUri(
           ////             new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString(entryName.Text))));
           ////       //  break;

           //// //}
        //}
    }
    }
}