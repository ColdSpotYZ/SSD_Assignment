using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Policy;

namespace Learn_Academy.Models
{
    public class Course
    {
        // user ID from AspNetUser table.
        // public string OwnerID { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Course Date")]
        [DataType(DataType.Date)]
        public DateTime CourseDate { get; set; }

        public string Category { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }
        /*
        #region Image

        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }

        public string GetInlineImageSrc()
        {
            if (Image == null || ImageContentType == null)
                return null;

            var base64Image = System.Convert.ToBase64String(Image);
            return $"data:{ImageContentType};base64,{base64Image}";
        }

        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {
            if (file == null)
                return;

            ImageContentType = file.ContentType;

            using (var stream = new System.IO.MemoryStream())
            {
                file.CopyTo(stream);
                Image = stream.ToArray();
            }
        }

        #endregion
        */

    }
}
