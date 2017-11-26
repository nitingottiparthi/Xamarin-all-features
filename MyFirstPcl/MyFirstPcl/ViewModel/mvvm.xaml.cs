using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstPcl.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mvvm : ContentPage
    {
        public mvvm()
        {
            InitializeComponent();
        }
    }
}
 //<ContentPage.Resources>
 //       <ResourceDictionary>
 //           <Style x:Key="RegularTextStyle" TargetType="Label"  BaseResourceKey="BaseTextStyle">
 //               <Setter Property = "FontSize" Value="14"/>
 //               <Setter Property = "TextColor" Value="Black"/>
 //               <Setter Property = "FontFamily" Value="proximanova-regular-webfont.ttf#proximanova-regular-webfont"></Setter>
 //           </Style>
 //           <Style x:Key="BasicLabelStyle" TargetType="Label"  BaseResourceKey="BaseTextStyle">
 //               <Setter Property = "FontSize" Value="14"/>
 //               <Setter Property = "TextColor" Value="Black"/>
 //               <Setter Property = "VerticalTextAlignment" Value="Center"/>
 //               <Setter Property = "FontFamily" Value="proximanova-regular-webfont.ttf#proximanova-regular-webfont"></Setter>
 //           </Style>
 //           <Style x:Key="ExpandListLabelStyle" TargetType="Label"  BaseResourceKey="BaseTextStyle">
 //               <Setter Property = "FontSize" Value="14"/>
 //               <Setter Property = "TextColor" Value="Black"/>
 //               <Setter Property = "VerticalTextAlignment" Value="Center"/>
 //               <Setter Property = "FontFamily" Value="proximanova-regular-webfont.ttf#proximanova-regular-webfont"></Setter>
 //           </Style>
 //           <Style x:Key="ListHeaderLabelStyle" TargetType="Label" >
 //               <Setter Property = "FontSize" Value="18"/>
 //               <Setter Property = "VerticalOptions" Value="Center"/>
 //               <Setter Property = "TextColor" Value="Black"/>
 //               <Setter Property = "FontFamily" Value="proximanova-bold-webfont.ttf#proximanova-bold-webfont"></Setter>
 //           </Style>
 //           <Style x:Key="buttonBaseStyle" TargetType="Button">
 //               <Setter Property = "TextColor" Value="White"/>
 //               <Setter Property = "BackgroundColor" Value="#3359de"/>
 //               <Setter Property = "FontFamily" Value="proximanova-regular-webfont.ttf#proximanova-regular-webfont" />
 //               <Setter Property = "FontSize" Value="20"/>
 //               <Setter Property = "FontAttributes" Value="Bold"/>
 //           </Style>
 //           <Style x:Key="PageHeadingStyle" TargetType="Label">
 //               <Setter Property = "TextColor" Value="Black"/>
 //               <Setter Property = "HorizontalOptions" Value="Center"/>
 //               <Setter Property = "HorizontalTextAlignment" Value="Center"/>
 //               <Setter Property = "FontFamily" Value="proximanova-bold-webfont.ttf#proximanova-bold-webfont" />
 //               <Setter Property = "FontSize" Value="24"/>
 //           </Style>
 //       </ResourceDictionary>
 //   </ContentPage.Resources>
 //   <ContentPage.ToolbarItems BackgroundColor = "Red" >
 //       < ToolbarItem x:Name="toolLogout" Name="Logout"  Order="Secondary" Priority="0" Icon="Logout_icon.png" Command="{Binding LogOut}"/>
 //       <ToolbarItem x:Name="toolFilter" Name="Filter"  Order="Primary" Priority="0" Icon="funnel.png" Command="{Binding GotToFilterPage}"/>
 //   </ContentPage.ToolbarItems>
    
 //   <ContentPage.BindingContext>
 //       <viewModel:AttendanceViewModel/>
 //   </ContentPage.BindingContext>
    