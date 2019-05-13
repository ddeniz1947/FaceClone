using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookClone.ViewModels
{
    public class PostNewPost
    {
       

        [Required(ErrorMessage ="Lütfen Bu Alanı Doldurunuz.")]
        public string Post_text { get; set; }

        [Required(ErrorMessage = "Lütfen Fotoğraf Linkinizi ekleyiniz.")]
        public string Post_img_link { get; set; }

        public string Gonderen { get; set; }
    }
  public class PostAkis
    {
       
        public string kadi { get; set; }
        public string post_img { get; set; }
        public string post_text { get; set; }
    }
}