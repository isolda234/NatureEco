using NatureEco.date;
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
    public partial class Detail : ContentPage
    {
        
        public Detail()
        {
    

            InitializeComponent();
           
        }
     

        async void OnHelp(object sender, EventArgs ev)
        {
            await Navigation.PushAsync(new Helpdesk());
        }

       
         

    }
}