using NatureEco.Services;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace NatureEco.ViewModels
{
    public class Userv : Base { 

        public Userv(string _username)
        {
            Username = _username;
           
        }
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }



    }
   
}


