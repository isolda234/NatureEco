using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Edit : ContentPage
    {
        public Image Image { get; private set; }
        public Edit()
        {
            InitializeComponent();
          

        }

      

        async void OnImage(object sender, EventArgs ev)
        {
           var result = await  MediaPicker.PickPhotoAsync( new MediaPickerOptions
             {
                Title="Please Pick a Photo"
            });
            var stream= await result.OpenReadAsync();
            
           userImage.Source = ImageSource.FromStream(() => stream);
           
            this.Image = userImage;
            userImage = new Image();

        }
     


    }
}