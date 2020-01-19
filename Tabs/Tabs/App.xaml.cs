using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tabs.Views.Principal;
using System.IO;

namespace Tabs
{
    public partial class App : Application
    {
        static SQLiteDb database;

        public static SQLiteDb Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteDb(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "DeclinaCurv.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage= new Principal();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
