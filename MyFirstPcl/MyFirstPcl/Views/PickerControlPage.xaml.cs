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
    public partial class PickerControlPage : ContentPage
    {
        public PickerControlPage()
        {
            InitializeComponent();
            //pkrMyFirstPicker.Items.Add("Nagarjun");
            //pkrMyFirstPicker.Items.Add("Nitin");
            //pkrMyFirstPicker.Items.Add("Sudheer");
            //pkrMyFirstPicker.Items.Add("Uday");
            //pkrMyFirstPicker.Items.Add("Mysura");
            List<string> names = new List<string>();
            names.Add("Nagarjun");
            names.Add("Nitin");
            names.Add("Sudheer");
            names.Add("Uday");
            names.Add("Mysura");
            pkrMyFirstPicker.ItemsSource = names;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            DisplayAlert("Name", "Your index is " + pkrMyFirstPicker.SelectedIndex + " and Name is " + pkrMyFirstPicker.Items[pkrMyFirstPicker.SelectedIndex], "Ok");
        }
    }
}