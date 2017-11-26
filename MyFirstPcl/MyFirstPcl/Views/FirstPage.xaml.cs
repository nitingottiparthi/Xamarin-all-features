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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void entryTextChange(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Hi", entryName.Text, "Ok");
        }

        private void CompletedEvent(object sender, EventArgs e)
        {
            DisplayAlert("Hi", entryName.Text, "Ok");
        }

        private void SecondTextChnage(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Hi", entryName1.Text, "Ok");
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hi", entryName.Text, "Ok");
        }
    }
}



//[assembly: Dependency(typeof(ToastMessage))]
//namespace LearningApp.Droid.Dependency_Service
//{
//    public class ToastMessage : IToastInterface
//    {
//        public string result = "";
//        ProgressDialog dialog = new ProgressDialog(Forms.Context);
//        public ToastMessage()
//        {

//        }
//        public void showMessage(string msg)
//        {
//            var context = Forms.Context;
//            Toast.MakeText(context, msg, ToastLength.Long).Show();
//        }

//        public void Loadpage()
//        {
//            dialog.SetCancelable(false);
//            dialog.Show();
//        }

//        public void StopLoad()
//        {
//            dialog.Dismiss();
//        }
//    }
//}




//public class CustomEditorRenderer : EditorRenderer
//{
//    protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e)
//    {
//        base.OnElementChanged(e);

//        Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "proximanova-regular-webfont.ttf");
//        Control.TextSize = 13;
//        Control.TextAlignment = Android.Views.TextAlignment.Center;
//        var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
//        shape.Paint.Color = Xamarin.Forms.Color.Black.ToAndroid();
//        shape.Paint.SetStyle(Paint.Style.Stroke);
//        Control.Background = shape;
//        GradientDrawable gd = new GradientDrawable();
//        gd.SetColor(Android.Graphics.Color.White);
//        gd.SetCornerRadius(10);
//        gd.SetStroke(2, Android.Graphics.Color.LightGray);
//        Control.SetBackground(gd);
//        Control.TextSize = 13;
//    }