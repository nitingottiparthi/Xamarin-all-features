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
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            List<MySourceClass> names = new List<MySourceClass>();
            names.Add(new MySourceClass { name = "Nag", name1 ="23" });
            names.Add(new MySourceClass { name = "Nag1" });
            names.Add(new MySourceClass { name = "Nag2" });
            names.Add(new MySourceClass { name = "Nag3" });
            names.Add(new MySourceClass { name = "Nag4" });
            names.Add(new MySourceClass
            {
                name = "name1",
                name1 = "name2"
            }
                );
            //List<string> names = new List<string>();
            //names.Add("Nag");
            //names.Add("Nag1");
            //names.Add("Nag2");
            //names.Add("Nag3");
            //names.Add("Nag4");

            //listFirstExample.ItemsSource = names;
        }
    }

    public class MySourceClass
    {
        public string name { get; set; }
        public string name1 { get; set; }


    }
}