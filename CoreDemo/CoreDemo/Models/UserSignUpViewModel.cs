using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyad Girin")]
        public string NameSurname { get; set; }



        public string Password { get; set; }




        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyore")]
        public string ConfirmPassword { get; set; }




        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail Adresi Girin")]
        public string Mail { get; set; }





        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }
    }
}
