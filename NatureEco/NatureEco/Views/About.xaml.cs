using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {
        public Xamarin.Forms.Color ForegroundColor { get; set; }

        public About()
        {
            InitializeComponent();
            Button button = new Button();
          

        }

        async void OnHome(object sender, EventArgs ev)
        {
         
            await Navigation.PushAsync(new Home());
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