
using System;
using System.Collections.Generic;
using System.ComponentModel;

using NatureEco.MenuItem;

using Xamarin.Forms;



namespace NatureEco.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
       
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
       
         
        public MainPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();




            menuList = new List<MasterPageItem>();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "HOME",
                Icon = "home.png",
                TargetType = typeof(User)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "ACCOUNT",
                Icon = "account.png",
                TargetType = typeof(Account)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "QUIZ",
                Icon = "iconquiz.png",
                TargetType = typeof(Quiz1)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "PUNCTUATION",
                Icon = "medal.png",
                TargetType = typeof(Quiz1)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "HELPDESK",
                Icon = "iconhelp.png",
                TargetType = typeof(Helpdesk)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "NEWS",
                Icon = "newss.png",
                TargetType = typeof(News)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "SETTINGS",
                Icon = "settings.png",
                TargetType = typeof(Quiz1)
            });
            navigationDrawerList.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(User)));

        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
         
         }
        



    }
}