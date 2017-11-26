using MyFirstPcl.DataBaseClasses;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MyFirstPcl.DataBaseClasses.TablesClass;

namespace MyFirstPcl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ImageTapped(object sender, EventArgs e)
        {
            MyFirstTable myTable = new MyFirstTable();
            myTable.cource = "Xamarin";
            myTable.name = "Nitin";
            DBClass.insertIntoMyFirstTable(myTable);
            var Data = DBClass.getFirstTableData();
            DBClass.UpdateName("Nagarjun");
            Data = DBClass.getFirstTableData();
            DBClass.DeleteRecord("Nagarjun");
            Data = DBClass.getFirstTableData();
            NavigationPage.SetHasNavigationBar(this, true);
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            var stream = file.GetStream();
            file.Dispose();
        }
    }
}