using MyFirstPcl.Models;
using MyFirstPcl.MyServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class MyDataBindingPage : ContentPage
    {
        RestService rService = new RestService();
        public MyDataBindingPage()
        {
            InitializeComponent();
            //string response = ServiceCalls.MyServiceMethod();
            //JObject jObject = JObject.Parse(response);//Converting response into json format
            //if(jObject["status"].ToString() == "success")
            //{
            //    RootObject robj = new RootObject();
            //    robj = JsonConvert.DeserializeObject<RootObject>(jObject.ToString());
            //    listFirstExample.ItemsSource = robj.data.products;
            //}
            //JObject jobj = new JObject();
            //jobj.Add("picker_token", "57d2be4ca4e5f73caa4e99b29efd69c7");
            //jobj.Add("invoice_id", "62877");
            //jobj.Add("user_id", "1234");
            //RootObject robj = rService.PostAsync<JObject, RootObject>("http://portal.ebutor.com/cpmanager/getorderdetailbyinvoice", jobj);
        }

        public async void BindData()
        {
            JObject jobj = new JObject();
            jobj.Add("picker_token", "57d2be4ca4e5f73caa4e99b29efd69c7");
            jobj.Add("invoice_id", "62877");
            jobj.Add("user_id", "1234");
            RootObject robj = await rService.PostAsync<JObject, RootObject>("http://portal.ebutor.com/cpmanager/getorderdetailbyinvoice", jobj);
            listFirstExample.ItemsSource = robj.data.products;

        }

        private void ItemTapped(object sender, EventArgs e)
        {
            //App.Current.MainPage = new MyGridPage();
            //Navigation.PushModalAsync(new MyGridPage());
            //Navigation.PushAsync(new MyGridPage());
            var info = (sender as Grid).BindingContext as Product;
            string productName = info.product_name;
            Navigation.PushAsync(new MyGridPage(productName));
        }

        private void LogoutClicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new NavigationPage(new MyGridPage());
        }
    }
}