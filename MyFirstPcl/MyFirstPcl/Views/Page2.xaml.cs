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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            var i=0;           

            for (i = 0; i < 10; i++)
            {
                DisplayAlert("nitin", i.ToString(), "ok");
                //i++;
            }          


        }

        private void CompletedEvent(object sender, EventArgs e)
        {

        }

        private void Calculate(object sender, EventArgs e)
        {
            //string r = "";
            //r = null;
            if (string.IsNullOrEmpty(firstentry.Text) == false)  //or if (firstentry.Text != null)
            {
                var value = double.Parse(firstentry.Text) / 2;
                DisplayAlert("nitin", value.ToString(), "ok");
            }
            else
            {
                DisplayAlert("nitin", "Invalid input", "ok");
            }
        }

        private void Buttonlicked(object sender, EventArgs e)
        {

        }
    }
}