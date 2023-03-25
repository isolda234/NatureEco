using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Security.Cryptography;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;
using NatureEco.Encripy;
using static Android.Provider.ContactsContract.CommonDataKinds;

namespace NatureEco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
 

    public partial class Register : ContentPage
    {
        public static string Eemaail { get; set; }
        Encripty en = new Encripty();

        public Register()
        {
            InitializeComponent();



        }

     


        async void SignUp( object sender,EventArgs e)
        {
            Eemaail = t_email.Text;
            var Username = t_username.Text;
            var Password = t_password.Text;
            const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            
            const string passawordregex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$@!%&*?])[A-Za-z\d#$@!%&*?]{8,12}$";

            var date = Date.Date;

           

            if (string.IsNullOrEmpty(Eemaail) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username)|| !(Regex.IsMatch(Eemaail, emailRegex))|| !(Regex.IsMatch(Password, passawordregex)))
            {
              
                await DisplayAlert("Alert", "Credencial Incorrect", "OK");

            }

            else
            {
                var password = en.Encrypt(t_password.Text);
                var user = await UserReposity.AddUser(Eemaail, password, Username, date);

                if (user)
                {
                    await DisplayAlert("Info", "Register is completed", "OK");
                    await Navigation.PopAsync();
                }
                else
                    await DisplayAlert("Alert", "Credencial Incorrect", "OK");

            }
        }

       
    }
}   





    
