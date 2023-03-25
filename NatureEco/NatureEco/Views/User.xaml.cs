using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NatureEco.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class User : ContentPage
    {


        public User()
        {
            InitializeComponent();
         


        }

            async void OnQuiz(object sender, EventArgs ev)
            {
                await Navigation.PushAsync(new Quiz1());
            }
            async void OnLogout(object sender, EventArgs ev)
            {

                await Navigation.PopAsync();
            }
        
    }
}