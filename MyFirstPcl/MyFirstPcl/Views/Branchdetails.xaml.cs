using MyFirstPcl.Models;
using System;
using System.Linq;
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
            var item = new listviewmodel { Branch = "ECE", FirstRank = "10", Hod = "Suresh", Id = 101, name = "Nitin", Principal = "Mahesh", Result = 1, Sports = "Cric", Student = "Yes", Subject = "Maths", Total = 123, Tutor = "Nag" };
            myList.Add(new listviewmodel { Branch = "ECE", FirstRank = "10", Hod = "Suresh", Id = 101, name = "Nitin", Principal = "Mahesh", Result = 1, Sports = "Cric", Student = "Yes", Subject = "Maths", Total = 123, Tutor = "Nag" });
            myList.Add(new listviewmodel { Branch = "EEE", FirstRank = "10", Hod = "Verranna", Id = 102, name = "Rahul", Principal = "Upendra", Result = 2, Sports = "basketBall", Student = "yes", Subject = "Ec", Total = 100, Tutor = "vinay" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "It", FirstRank = "12", Hod = "Someshwar", Id = 104, name = "Santosh", Principal = "Suresh", Result = 4, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            myList.Add(new listviewmodel { Branch = "Cse", FirstRank = "11", Hod = "Verranna", Id = 103, name = "Varun", Principal = "Suresh", Result = 3, Sports = "VolleyBall", Student = "yes", Subject = "Stld", Total = 101, Tutor = "chandu" });
            lstMyList.ItemsSource = myList;
            var eceDetails = myList.Where(a => a.Branch == "ECE").ToList();
            var csedetails = myList.Where(a => a.Id == 103).ToList();
            var details = myList.Contains(item);//checks for item in the list
            var details1 = myList.ElementAt(2);
            var details2 = myList.Where(a => a.Id == 103 && a.name == "Suresh").FirstOrDefault();
            var details3 = myList.GroupBy(a => a.Branch);
            var details4 = myList.IndexOf(item);
            var details5 = myList.Remove(item);
            var details6 = myList.Where(a => a.Branch == "EEE").ToList();
            foreach(var item2 in details6)
            {
                myList.Remove(item2);
            }
            var details7 = myList.Sum(a => a.Id);
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null)
            //    return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

        private void Search(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchName.Text))
            {
                var details = (ObservableCollection<listviewmodel>)myList.Where(a => a.name.Contains(searchName.Text));
                lstMyList.ItemsSource = details;

            }
            else
            {
                lstMyList.ItemsSource = myList;
            }
        }


            //    if(!string.IsNullOrEmpty(searchName.Text))
            //    {
            //        var details = (ObservableCollection<listviewmodel>)myList.Where(a => a.name.Contains(searchName.Text));
            //lstMyList.ItemsSource = details;
            //    }
            //    else
            //    {
            //        lstMyList.ItemsSource = myList;
            //    }
            //}

            private void DeleteItem(object sender, EventArgs e)
        {
            var item = ((sender as MenuItem).BindingContext as listviewmodel);
            myList.Remove(item);
        }

        private void ViewDetails(object sender, EventArgs e)
        {
            var details = ((sender as MenuItem).BindingContext as listviewmodel);
            //Navigation.PushAsync(new Page(id));
        }
    }
}