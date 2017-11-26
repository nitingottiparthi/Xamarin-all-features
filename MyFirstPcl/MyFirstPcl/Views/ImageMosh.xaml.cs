using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstPcl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageMosh : ContentPage
    {
        private int _imageId = 1;
        public ImageMosh()
        {
            InitializeComponent();
            _imageId = 1;
            GetImage();
        }

         void GetImage()
        {
            Image.Source = new UriImageSource
            {
                Uri = new Uri (String.Format("http://lorempixel.com/1920/1080/city/{0}", _imageId)),
            cachingEnabled = false

            };
            
        }

        private void LeftClicked(object sender, EventArgs e)
        {

        }

        private void rightClicked(object sender, EventArgs e)
        {

        }
    }
}