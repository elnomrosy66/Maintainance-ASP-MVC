using Maintainance.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Maintainance.Helpers.Image
{
    public class Image
    {
        public bool insertimage(OurWork ourwork)
        {

            if (IsValid(ourwork.ImageFile))
            {
                String filename = Path.GetFileNameWithoutExtension(ourwork.ImageFile.FileName.ToString());
                string extension = Path.GetExtension(ourwork.ImageFile.FileName);

                //check if folder exist
                var folder = HttpContext.Current.Server.MapPath("~/Image/"+DateTime.Today.ToString("dd/MM/yyyy")+ "/");
                if (!Directory.Exists(folder))
                {
                    //create folder
                    Directory.CreateDirectory(folder);
                }

                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                ourwork.Image = "/Image/" +DateTime.Today.ToString("dd/MM/yyyy")+ "/" + filename;
                filename = Path.Combine(HttpContext.Current.Server.MapPath("/Image/" + DateTime.Today.ToString("dd/MM/yyyy") + "/"), filename);
                ourwork.ImageFile.SaveAs(filename);
                return true;
            }

            return false;
        }

        public bool IsValid(object value)
        {
            bool isValid = false;
            var file = value as HttpPostedFileBase;

            if (file == null || file.ContentLength > 1 * 6000 * 6000)
            {
                return isValid;
            }

            if (IsFileTypeValid(file))
            {
                isValid = true;
            }
            return isValid;
        }

        private bool IsFileTypeValid(HttpPostedFileBase file)
        {
            //bool isValid = false;
            bool isValid = true;

            /*   try
               {
                   using (var img = System.Drawing.Image.FromStream(file.InputStream))
                   {
                       if (IsOneOfValidFormats(img.RawFormat))
                       {
                           isValid = true;
                       }
                   }
               }
               catch
               {
                   //Image is invalid
               }*/
            return isValid;
        }



    }
}