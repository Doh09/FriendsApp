using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace FriendsApp
{
    class FriendsManager
    {
        public List<Friend> Friends { get; set; }
        #region Singleton pattern
        private static FriendsManager instance;
        /// <summary>
        /// Returns the FriendsManager singleton object.
        /// </summary>
        /// <returns></returns>
        public static FriendsManager GetInstance()
        {
            if (instance == null)
                instance = new FriendsManager();

            return instance;
        }
        #endregion
        private FriendsManager()
        {
            Friends = GetMockFriendList();
        }

        /// <summary>
        /// Add a friend to the friends list
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public Friend AddFriend(Friend f)
        {
            Friends.Add(f);
            return f;
        }

        /// <summary>
        /// Returns true if a Friend with a matching ID was found and removed, otherwise returns false.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool RemoveFriend(Friend f)
        {
            return (Friends.RemoveAll(x => x.id == f.id)) != 0;
        }

        /// <summary>
        /// Locates a Friend with a matching ID, switches all properties with the given Friend.
        /// Returns the found/matching friend, returns null if no match found.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public Friend EditFriend(Friend f)
        {
            Friend toEdit = Friends.FirstOrDefault(x => x.id == f.id);
            if (toEdit != null) { 
            toEdit.Address = f.Address;
            toEdit.CustomText = f.CustomText;
            toEdit.FirstName = f.FirstName;
            toEdit.LastName = f.LastName;
            toEdit.PhoneNumber = f.PhoneNumber;
            toEdit.ProfileImgPath = f.ProfileImgPath;
            }
            return toEdit;
        }

        /// <summary>
        /// Creates a list of mock data for testing.
        /// Loop amount can be increased if more mock Friend objects are needed.
        /// Default loop amount is 5.
        /// </summary>
        /// <returns></returns>
        private List<Friend> GetMockFriendList(int loopAmount = 5)
        {
            List<Friend> Friends = new List<Friend>();
            for (int i = 0; i < loopAmount; i++)
            {
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
                }
                );
            }
            return Friends;
        }

    }
}
