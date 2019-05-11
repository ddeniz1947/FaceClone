using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookClone.ViewModels
{
    public class RegisterReg
    {
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        public string Kadi { get; set; }

        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        [DataType(DataType.Password)]
        public string Parola { get; set; }

        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Bu Alanı Doldurunuz.")]
        public string Telno { get; set; }
    }
}