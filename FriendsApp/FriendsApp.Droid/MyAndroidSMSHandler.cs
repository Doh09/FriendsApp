using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Telephony;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FriendsApp.Droid;
using Interfaces;
using Xamarin.Forms;
[assembly: Dependency(typeof(MyAndroidSMSHandler))]
namespace FriendsApp.Droid
{
    class MyAndroidSMSHandler : ISMSHandler
    {
        public void SendSMS(string tlf, string body)
        {
            SmsManager.Default.SendTextMessage(tlf, null, body, null, null);
        }

        public void StartSMSApp(string tlf, string body)
        {
            var activity = (Activity)Forms.Context;
            var smsUri = Android.Net.Uri.Parse("smsto:" + tlf);
            var smsIntent = new Intent(Intent.ActionSendto, smsUri);
            smsIntent.PutExtra("sms_body", body);
            activity.StartActivity(smsIntent);

        }

    }
}