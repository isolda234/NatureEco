
using NatureEco.date;
using NatureEco.Services;
using NatureEco.Views;

using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Forms;

namespace NatureEco
{
    public partial class App : Application
    {
        static TabelaUser database;

        public static TabelaUser Database
        {
            get
            {
                if (database == null)
                {
                    database = new TabelaUser(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"natueecco.db3"));
                }
                return database;
            }
        }



        public App()
        {
         
            InitializeComponent();


            MainPage =  new NavigationPage( new MainPage());
          


        }

     

        protected override void OnStart()
        {
            Console.WriteLine("App start");
            Debug.WriteLine("App starts");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("App sleep");
            Debug.WriteLine("App sleeps");
        }

        protected override void OnResume()
        {
            Console.WriteLine("App resume");
            Debug.WriteLine("App resumes");

        }

     
    }
}
