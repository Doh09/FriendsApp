using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Xamarin.Forms;

namespace FriendsApp
{
    public partial class Main : MasterDetailPage
    {
        Friends_MasterPage masterPage;
        public Main()
        {
            InitializeComponent();
            masterPage = new Friends_MasterPage();
            Master = masterPage;
            Friend detailParameter = new Friend();
            detailParameter.id = -1; //Setting id to -1 to acknowledge this friend input is "fake"
            Detail = new NavigationPage(new FriendsDetailPage(detailParameter));
            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Friend;
            if (item != null)
            {
                Detail = new NavigationPage(new FriendsDetailPage(item));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
                MasterBehavior = MasterBehavior.Split;
            }
        }
    }
}
