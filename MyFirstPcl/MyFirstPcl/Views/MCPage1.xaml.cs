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
    public partial class MCPage1 : ContentPage
    {
        public MCPage1()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MCPage1, string>(this, "Hello", (sender,args) =>
             {
                 lblMyName.Text = args;
             });
        }

        private void GoToNextPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MCPage2());
        }
    }
}