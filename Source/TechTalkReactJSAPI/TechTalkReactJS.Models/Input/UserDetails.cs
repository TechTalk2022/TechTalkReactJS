using System;
using System.Collections.Generic;
using System.Text;

namespace TechTalkReactJS.Models.Input
{
    public class UserDetails
    {
        public Int32 UserId { get; set; } = 0;
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public Int16 GenderId { get; set; } = 1;
        public Int16 RoleId { get; set; } = 1;
        public string DOB { get; set; }
    }
}
