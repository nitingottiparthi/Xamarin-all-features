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
    public partial class restservicestoken : ContentPage
    {
        public restservicestoken()
        {
            InitializeComponent();
    //        response = EbutorAPI.RegistrationStep2(Constants.PhoneNumber, entryOTP.Text);

    //        LoginData loginData;
    //        JObject jObject = JObject.Parse(response);
    //        if (jObject["status"].ToString() == "success")
    //        {

    //            if (jObject["data"]["data"].ToString() != "[]")
    //            {
    //                loginData = JsonConvert.DeserializeObject<LoginData>(jObject["data"].ToString());
    //                DbClass.InsertLoginDetails(response);

    //                Constants.customerToken = loginData.data.customer_token;
    //                Constants.userName = loginData.data.firstname + " " + loginData.data.lastname;
    //                Constants.customerID = loginData.data.customer_id;
    //                Constants.wh_id = loginData.data.le_wh_id;
    //                Constants.hub_id = loginData.data.hub;
    //                Constants.legal_entity_id = loginData.data.legal_entity_id;
    //                if (loginData.data.lp_feature != null && loginData.data.lp_feature.ToString() != "")
    //                {
    //                    foreach (var item in loginData.data.lp_feature)
    //                    {
    //                        if (item.is_menu == "1")
    //                        {
    //                            menuitems.Add(item);
    //                        }
    //                        else
    //                        {
    //                            submenuitems.Add(item);
    //                        }
    //                    }
    //                    List<Menu> _menu = new List<Menu>();

    //                    foreach (var itemtest in menuitems)
    //                    {
    //                        Menu menuitem = new Menu();
    //                        menuitem.MenuName = itemtest.name;
    //                        menuitem.MainItemId = itemtest.feature_code;
    //                        menuitem.MainItemId = itemtest.feature_code;
    //                        List<MenuSub> _submenu = new List<MenuSub>();
    //                        foreach (var item1 in submenuitems)
    //                        {

    //                            if (itemtest.feature_id == item1.parent_id)
    //                            {
    //                                MenuSub submenuitem = new MenuSub();
    //                                submenuitem.MenuSubName = item1.name;
    //                                submenuitem.SubItemId = item1.feature_code;
    //                                _submenu.Add(submenuitem);
    //                            }
    //                            menuitem.MenuSubList = _submenu;
    //                        }
    //                        _menu.Add(menuitem);
    //                    }
    //                    Constants.Dynamicmenuitems = _menu;
    //                    App.Current.MainPage = new Home(_menu);
    //                }
    //                else
    //                {
    //                    await DisplayAlert("Ebutor", "User does not contain roles", "OK");
    //                    App.Current.MainPage = new NavigationPage(new Login()) { BarBackgroundColor = Color.Blue, BarTextColor = Color.White };
    //                }
    //            }
    //        }
    }
}


//public static string HoldOrder(string orderID, string reasonID, string date, string orderCode)
//{
//    try
//    {
//        JObject details = new JObject();
//        details.Add("deliver_token", Constants.customerToken);
//        details.Add("next_delivery_date", date);
//        details.Add("order_id", orderID);
//        details.Add("hold_reason_id", reasonID);
//        details.Add("order_code", orderCode);
//        details.Add("module_id", "1");
//        // SKUModal info = new SKUModal();
//        string response = restService.PostRequest(Constants.NewUrl + "getOrderHold", "data=" + details);
//        JObject jObject = JObject.Parse(response);
//        return jObject["message"].ToString();
//    }
//    catch (Exception ex)
//    {
//        return ex.Message.ToString();
//    }
//}

//public static List<CollectionDetailsModal> getCollectionDetails(string date = null)
//{
//    try
//    {
//        JObject details = new JObject();
//        details.Add("deliver_token", Constants.customerToken);
//        details.Add("date", date);
//        details.Add("module_id", "1");
//        details.Add("user_id", Constants.customerID);
//        string response = restService.PostRequest(Constants.NewUrl + "getCollectiondetails", "data=" + details);
//        JObject jObject = JObject.Parse(response);
//        if (jObject["status"].ToString() == "success")
//        {
//            List<CollectionDetailsModal> paymentMode = JsonConvert.DeserializeObject<List<CollectionDetailsModal>>(jObject["data"].ToString());
//            return paymentMode;
//        }
//    }
//    catch (Exception ex)
//    {

//    }
//    return null;
//}