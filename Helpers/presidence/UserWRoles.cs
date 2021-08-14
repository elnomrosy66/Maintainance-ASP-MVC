using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maintainance.Helpers.presidence
{
    public class UserWRoles
    {

        public String RoleId { get; set; }
        public String UserId { get; set; }
        [Display(Name="اسم المستخدم")]
        public String Username { get; set; }
        [Display(Name = "البريد الالكتروني")]
        public String Email { get; set; }
        [Display(Name = "الدور")]
        public String Role { get; set; }


    }
}