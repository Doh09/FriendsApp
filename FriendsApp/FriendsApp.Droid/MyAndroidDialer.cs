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
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(MyAndroidDialer))]
namespace FriendsApp.Droid
{
    class MyAndroidDialer : IDialer
    {
        public void Call(string number)
        {
            Dial(Intent.ActionCall, number);
        }

        public void StartDial(string number)
        {
            Dial(Intent.ActionDial, number);
        }

        private void Dial(String dialMethod, String number)
        {
            var activity = (Activity)Forms.Context;
            var uri = Android.Net.Uri.Parse("tel:" + number);
            var intent = new Intent(dialMethod, uri);
            activity.StartActivity(intent);
        }
    }

}