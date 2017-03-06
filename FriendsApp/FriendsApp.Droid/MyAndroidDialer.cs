using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FriendsApp.Droid;
using Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(MyAndroidDialer))]
namespace FriendsApp.Droid
{
    class MyAndroidDialer : IDialer
    {
        public void Call(string number)
        {
            IToast MyAndroidToast = new MyAndroidToast();
            MyAndroidToast.DisplayToast("Call to " + number + " performed");
        }

        public void StartDial(string number)
        {
            IToast MyAndroidToast = new MyAndroidToast();
            MyAndroidToast.DisplayToast("Dial to " + number + " performed");
        }
    }

}