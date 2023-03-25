using NatureEco.ViewModels;
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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModelcs();
        }
        async void OnHome(object sender, EventArgs ev)
        {
            await Navigation.PushAsync(new Home());
        }

        async void OnAbout(object sender, EventArgs ev)
        {
            await Navigation.PopAsync();
        }
        
    }
}