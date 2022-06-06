using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcModelValidation.Models
{
    public class Kullanici
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı alanı zorunludur")] // zorunlu alan...
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre alanı zorunludur")] // zorunlu alan...
        [StringLength(10, ErrorMessage = "Şifreniz min 3 max 10 karakter aralığında olmalıdır...", MinimumLength = 3)] // MAx 10, min 3 karakter
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifre tekrarı giriniz")]
        [Compare("Password", ErrorMessage = "Şifreleriniz eşleşmiyor")]
        public string Password2 { get; set; }

        [EmailAddress(ErrorMessage = "Email Formatı Hatalıdır...")]
        [Required(ErrorMessage = "Lütfen Email Adresi Giriniz")]
        public string EmailAdress { get; set; }
    }
}