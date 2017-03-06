﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FriendsApp
{
    public partial class App : Application
    {
        public static IToast MyToast { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new FriendsApp.Friends_MasterPage();
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
