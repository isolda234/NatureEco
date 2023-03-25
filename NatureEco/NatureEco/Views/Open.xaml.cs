

using System;
using Android.App;
using Android.Widget;
using Android.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Open : ContentPage
    {
       
        
        public Open()
        {
            InitializeComponent();

            Device.StartTimer(new TimeSpan(0,0,10),() =>
            {
                //o programa vai correndo durante 10 segundo na layout opem

                Device.BeginInvokeOnMainThread(async () =>
                {
                    //apos o termino dos 10 secundos ele chama outra pagina e não volta a exectuar o mesmo, pos returnou false.
                    await Navigation.PushAsync(new Home());
                   
                  
                });
                return false;

            });
       

         }

        





    }
}