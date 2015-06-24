using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace TelerikListViewXF
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //Populating Data
            //MainPage = new MainPage();

            //Pull to Refresh Functionality
            //MainPage = new PullToRefresh();

            //Swiping items to increase or decrease values
            MainPage = new SwipeAnItem();
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
