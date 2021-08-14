using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maintainance.Helpers.presidence
{
    public class Users
    {
        public class GroupedUserViewModel
        {
            public List<UserViewModel> Users { get; set; }
            public List<UserViewModel> Admins { get; set; }
        }
        public class UserViewModel
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public string RoleName { get; set; }
        }
    }
}