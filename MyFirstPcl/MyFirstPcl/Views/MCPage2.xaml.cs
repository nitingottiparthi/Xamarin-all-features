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
    public partial class MCPage2 : ContentPage
    {
        public MCPage2()
        {
            InitializeComponent();
        }

        private void goBack(object sender, EventArgs e)
        {
            MCPage1 mc1 = new MCPage1();
            MessagingCenter.Send(mc1, "Hello", "Nagarjun");
            Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            MCPage1 mc1 = new MCPage1();
            MessagingCenter.Send(mc1, "Hello", "Nagarjun");
            Navigation.PopAsync();
            return base.OnBackButtonPressed();
        }

    }
}