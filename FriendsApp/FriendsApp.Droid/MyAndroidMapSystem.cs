using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FriendsApp.Droid;
using Interfaces;
using Xamarin.Forms;

namespace FriendsApp.Droid
{
    public class MyAndroidMapSystem : IMapSystem
    {
        public void ShowLocation()
        {
            //Make activity so it can be used by Android
            var activity = (Activity) Forms.Context;

            //Get longitude and all that
            var geoUri = Android.Net.Uri.Parse("geo:42.374260,-71.120824");
            //Tells it what to do
            var mapIntent = new Intent(Intent.ActionView, geoUri);

            //Make a bundle
            var bundle = new Bundle();
            
            //Initilize the formsmap
            Xamarin.FormsMaps.Init(activity,bundle);
            //Makes a geocode
            var geo = new Geocoder(activity);
            //An Address to test on
            var addresses = geo.GetFromLocationName(
                "50 Church St, Cambridge, MA",1);

            //Start the thing
            activity.StartActivity(mapIntent);

        }

    

        public void FindRoute()
        {
            throw new NotImplementedException();
        }
    }
}