using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entities;
using Xamarin.Forms;

namespace FriendsApp
{
    public partial class FriendsDetailPage : ContentPage
    {
        private static IDialer dialer = DependencyService.Get<IDialer>();
        private static ISMSHandler sms = DependencyService.Get<ISMSHandler>();
        private static IMapSystem mapSystem = DependencyService.Get<IMapSystem>();

        private Friend Friend { get; set; }
        public FriendsDetailPage(Friend friend)
        {
            InitializeComponent();
            Friend = friend;
            if (Friend == null || Friend.id == -1) //If no friend selected
            {
                DisplayInstructions();
            }
            else //Friend is selected
            {
                DisplayFriend();
            }
        }

        private void DisplayInstructions()
        {
            Title = "No friend selected";
            Label lbl = new Label();
            lbl.HorizontalTextAlignment = TextAlignment.Center;;
            lbl.Text = "Please select a friend from the menu";
            Content = lbl;
        }

        private void DisplayFriend()
        {
            Title = Friend.FirstName + " " + Friend.LastName;
            lblName.Text = $"{Friend.FirstName} {Friend.LastName}";
            lblName.FontSize *= 3; 
            imgFriend.Source = Friend.ProfileImgPath;

        }

        private void Call_Button_OnClicked(object sender, EventArgs e)
        {
            dialer.StartDial("12345678");
        }

        private void SMS_Button_OnClicked(object sender, EventArgs e)
        {
            sms.StartSMSApp("12345678", "Test");
        }
    }
}
