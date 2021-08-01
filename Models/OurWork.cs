using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maintainance.Models
{
    public class OurWork
    {
        public int ID{ get; set; }
        [Required(ErrorMessage ="لا يمكن ان يترك العنوان فارغ")]
        [DataType(DataType.Text)]
        public String Title { get; set; }
        [Required(ErrorMessage ="لا يمكن ان يترك الوصف فارغ")]
        [DataType(DataType.Text)]
        public String Description { get; set; }
        
    }
}