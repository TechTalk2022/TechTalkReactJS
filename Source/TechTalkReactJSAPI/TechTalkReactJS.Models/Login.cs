using System;
using System.ComponentModel.DataAnnotations;

namespace TechTalkReactJS.Models
{
    public class Login
    {
      
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public Int32 UserId { get; set; } = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
