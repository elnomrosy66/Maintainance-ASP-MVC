using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maintainance.Models
{
    public class OurWork
    {
        public int ID{ get; set; }
        [Required(ErrorMessage ="لا يمكن ان يترك العنوان فارغ")]
        [Display(Name ="العنوان")]
        [DataType(DataType.Text)]
        public String Title { get; set; }
        [Required(ErrorMessage ="لا يمكن ان يترك الوصف فارغ")]
        [Display(Name = "الوصف")]
        [DataType(DataType.Text)]
        public String Description { get; set; }
        [Display(Name = "")]
        public String Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}