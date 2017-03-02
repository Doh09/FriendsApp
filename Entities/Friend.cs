using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Friend
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImgPath { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; } //Make Address object
        public string CustomText { get; set; }
    }
}
