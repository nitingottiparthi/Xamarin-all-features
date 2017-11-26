using MyFirstPcl.DataBaseClasses;
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
        }

        private void ImageTapped(object sender, EventArgs e)
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
        }
    }
}