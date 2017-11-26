using MyFirstPcl.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstPcl.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Branchdetails : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }
        ObservableCollection<listviewmodel> myList = new ObservableCollection<listviewmodel>();
        public Branchdetails()
        {
            InitializeComponent();
            myList.Add(new listviewmodel { Branch = "ECE", FirstRank = "10", Hod = "Suresh", Id = 101, name = "Nitin", Principal = "Mahesh", Result = 1, Sports = "Cric", Student = "Yes", Subject = "Maths", Total = 123, Tutor = "Nag" });
            myList.Add(new listviewmodel { Branch = "EEE", FirstRank = "10", Hod = "Verranna", Id = 102, name = "Rahul", Principal = "Upendra", Result = 2, Sports = "basketBall", Student = "yes", Subject = "Ec", Total = 100, Tutor = "vinay" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "It", FirstRank = "12", Hod = "Someshwar", Id = 104, name = "Santosh", Principal = "Suresh", Result = 4, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            lstMyList.ItemsSource = myList;
            
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //    return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }
    }
}