
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;
using NatureEco;
using Xamarin.Forms.Xaml;
using System.IO;
using NatureEco.Encripy;
using Android.Widget;
using NatureEco.date;

namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        Encripty en = new Encripty();
        userModel user = new userModel();

        public Login()
        {
            InitializeComponent();
            

        }

        async void Reset(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reset_passsword());
        }

        async void SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

         async void SignIn(object sender, EventArgs e)
        {
          var  Email = email.Text;
            var Password = en.Encrypt(password.Text);
          
         

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {

                await DisplayAlert("Information", "Confirme o email e/ou senha","ok" );
            }
            else
            {
                var user = await UserReposity.GetUser(Email);

                if (user != null)
                {
                    if (Email == user.Email && Password == user.Password)
                    {
                        
                        await DisplayAlert("Welcome","Register Successfully","ok");

                        await Navigation.PushAsync(new MainPage());
                    }
                    else
                    {
                        await DisplayAlert("Information", "Confirme o email e/ou senha", "ok");
                    }
                }
                else
                {
                    await DisplayAlert("Alert", "Usuário não encontrado","ok");
                }
            }


        }






    }
}