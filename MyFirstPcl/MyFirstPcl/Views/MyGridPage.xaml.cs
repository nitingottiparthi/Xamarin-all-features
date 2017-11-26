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
    public partial class MyGridPage : ContentPage
    {
        public MyGridPage()
        {
            InitializeComponent();
        }

        public MyGridPage(string myName)
        {
            InitializeComponent();
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lbl5.Text = lbl6.Text = lbl7.Text = lbl8.Text = lbl9.Text = lbl10.Text = lbl11.Text = lbl12.Text = myName;
        }
	}
}