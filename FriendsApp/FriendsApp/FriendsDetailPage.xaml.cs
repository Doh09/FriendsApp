using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Xamarin.Forms;

namespace FriendsApp
{
    public partial class FriendsDetailPage : ContentPage
    {
        private Friend Friend { get; set; }
        public FriendsDetailPage(Friend friend)
        {
            InitializeComponent();
            Friend = friend;
            Title = Friend.FirstName + " " + Friend.LastName;
        }
    }
}
