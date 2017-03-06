using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Graphics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Interfaces;

namespace FriendsApp.Droid
{
    class MyAndroidToast : IToast
    {
        public void DisplayToast(string message)
        {

            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}