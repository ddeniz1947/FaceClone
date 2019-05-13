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
        public string post_text;

        [Required(ErrorMessage = "Lütfen Fotoğraf Linkinizi ekleyiniz.")]
        public string post_img_link;

        public string gonderen;
    }
  public class PostAkis
    {
        public string kadi;
        public string post_img;
        public string post_text;
    }
}