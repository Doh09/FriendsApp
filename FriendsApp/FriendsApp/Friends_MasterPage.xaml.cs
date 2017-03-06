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
        public ListView ListView { get; set; }
        private FriendsManager fm = FriendsManager.GetInstance();
        public Friends_MasterPage()
        {
            InitializeComponent();
            ListView = listView; //sets the listview property to reference the XAML listview.
            NavigationPage.SetHasNavigationBar(this, true); //this line appears to control whether or not we have a title bar.
            listView.ItemsSource = fm.Friends; //Get source from FriendsManager
            IDialer dialer = DependencyService.Get<IDialer>();
        }

        //private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as Friend;
        //    if (item != null)
        //    {
        //        await Navigation.PushAsync(new FriendsDetailPage(item));
        //    }
        //}
    }
}
