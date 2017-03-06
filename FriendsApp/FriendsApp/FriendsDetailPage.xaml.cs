using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Xamarin.Forms;

namespace FriendsApp
{
    public partial class FriendsDetailPage : ContentPage
    {
        private static IDialer dialer = DependencyService.Get<IDialer>();
        //private static ISMSHandler sms = DependencyService.Get<ISMSHandler>();
        public FriendsDetailPage()
        {
            InitializeComponent();
        }
    }
}
