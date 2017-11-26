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
    public partial class DailPage : ContentPage
    {
        public DailPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel://" + entryName.Text));
        }
    }
}