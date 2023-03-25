using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Widget;
using NatureEco.date;

using Xamarin.Essentials;

namespace NatureEco.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {

   
       

        UserReposity userReposity = new UserReposity();

        public Account( string email)
        {
          
            InitializeComponent();
          
           


        }
      


        async void OnEdit(object sender, EventArgs ev)
        {
            await Navigation.PushAsync(new Edit());
        }
    }
}