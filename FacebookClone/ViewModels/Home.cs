using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookClone.ViewModels
{
    public class HomeIndex
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string kadi { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Giriniz.")]
        [DataType(DataType.Password)]
        public string parola { get; set; }
    }
}