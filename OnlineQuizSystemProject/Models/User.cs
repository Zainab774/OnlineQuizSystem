using System;
using OnlineQuizSystemProject.Models;
using System.Collections.Generic;
using System.Text;

namespace OnlineQuizSystemProject.Models
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }   // "student" or "admin"
        public string? FullName { get; set; }
    }

}

    

