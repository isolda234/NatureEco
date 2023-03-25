using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.App;

namespace NatureEco.Views
{
  

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        
        public Home()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
           
        }
        async void OnStar (object sender,EventArgs ev)
        {
            await Navigation.PushAsync(new Login());
        }
     
        async void OnAbout(object sender, EventArgs ev)
        {
            await Navigation.PushAsync(new About());
        }
        async void OnContact(object sender, EventArgs ev)
        {
            await Navigation.PushAsync(new Contact());
        }
    }
}