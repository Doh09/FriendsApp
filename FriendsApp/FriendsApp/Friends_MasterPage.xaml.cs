using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace FriendsApp
{
    public partial class Friends_MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public Friends_MasterPage()
        {
            InitializeComponent();

            var Friends = GetMockFriendList();
            listView.ItemsSource = Friends;

        }

        private List<Friend> GetMockFriendList() {
           List<Friend> Friends = new List<Friend>();
            Friends.Add(new Friend
            {
                id = 1,
                FirstName = "Martin",
                LastName = "Gustavsen",
                Address = new Address
                {
                    Country = "Denmark",
                    City = "Esbjerg",
                    ZipCode = "6700",
                    StreetName = "Spangsbjerg Møllevej",
                    StreetNumber = 62
                },
                PhoneNumber = 88888888,
                ProfileImgPath = "https://scontent-arn2-1.xx.fbcdn.net/v/t1.0-9/946009_528195123932323_1817755414_n.jpg?oh=041c2de64e16101e78e38f95d51af16d&oe=592B8F54",
                CustomText = "Martin is a student at EASV"
            });
            Friends.Add(new Friend
            {
                id = 1,
                FirstName = "Alex",
                LastName = "Andreasen",
                Address = new Address
                {
                    Country = "Denmark",
                    City = "Esbjerg V",
                    ZipCode = "6710",
                    StreetName = "Vædderens Kvarter",
                    StreetNumber = 75
                },
                PhoneNumber = 88888888,
                ProfileImgPath = "https://scontent-arn2-1.xx.fbcdn.net/v/t1.0-9/13718784_10209527266195112_8688651414822860447_n.jpg?oh=1586b528cefc7073cfbae579071c9c14&oe=5929B66A",
                CustomText = "Alex is a student at EASV"
            });
            Friends.Add(new Friend
            {
                id = 1,
                FirstName = "Huehue",
                LastName = "Huehuesen",
                Address = new Address
                {
                    Country = "Denmark",
                    City = "Esbjerg",
                    ZipCode = "6700",
                    StreetName = "Awesome Road",
                    StreetNumber = 9999
                },
                PhoneNumber = 88888888,
                ProfileImgPath = "HuehuesImagePath",
                CustomText = "Huehue is a student at EASV"
            });
            return Friends;
        }
    }
}
