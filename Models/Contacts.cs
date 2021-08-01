﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maintainance.Models
{
    public class Contacts
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="رقم الهاتف مطلوب")]
        [MinLength(5,ErrorMessage ="لا يقل رقم الهاتف عن خمسه ارقام ")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="لا يجب ان يحتوي رقم الهاتف علي رموز")]
        public String PhonNumber { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "يجب ان يحتوي البريد علي @  و . ")]
        public String Email { get; set; }

        public String SiteName { get; set; }
    }
}