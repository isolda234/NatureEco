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
    public partial class Helpdesk : ContentPage
    {
        public Helpdesk()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModelcs();
        }
    }
}