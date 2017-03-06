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
            Title = "Friends menu";
            MenuTitle.BackgroundColor = Color.Silver;
        }

        private void Btn_AddFriend_OnClicked(object sender, EventArgs e)
        {
            App.MyToast.DisplayToast("User now needs to be sent to 'Add Friend' page");
        }
    }
}
