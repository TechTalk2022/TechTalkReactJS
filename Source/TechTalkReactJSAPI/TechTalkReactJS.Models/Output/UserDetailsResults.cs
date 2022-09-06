using System;
using System.Collections.Generic;
using System.Text;
using TechTalkReactJS.Models.Input;

namespace TechTalkReactJS.Models.Output
{
    public class UserDetailsResults
    {
        public List<UserDetails> UsersList { get; set; }
        public List<UserRole> RoleList { get; set; }

    }
}
