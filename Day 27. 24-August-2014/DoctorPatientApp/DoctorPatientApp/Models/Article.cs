using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatientApp.Models
{
    public class Article
    {
        public int ArticleId { set; get; }
        [Required]
        [DisplayName("Heading")]
        public string ArticleHeading { set; get; }
        [Required]
        [DisplayName("Content")]
        public string ArticleContent { set; get; }
        [DisplayName("Picture")]
        public string Picture { set; get; }
    }
}