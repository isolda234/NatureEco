

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NatureEco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz1 : ContentPage
    {
       

        public Quiz1()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }
     

        
        async void OnReturn(object sender, EventArgs ev)
        {
          
            await Navigation.PopAsync();
        }
    }
}