using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace FriendsApp
{
    public partial class Friends_MasterPage : ContentPage
    {
        private FriendsManager fm = FriendsManager.GetInstance();
        public Friends_MasterPage()
        {
            InitializeComponent();
            
            listView.ItemsSource = fm.Friends;
            IDialer dialer = DependencyService.Get<IDialer>();
        }


        private void Cell_OnTapped(object sender, EventArgs e)
        {
            App.MyToast.DisplayToast("Clicked");
        }
    }
}
