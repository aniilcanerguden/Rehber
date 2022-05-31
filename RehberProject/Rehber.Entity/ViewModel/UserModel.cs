using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.ViewModel
{
  public class UserModel
    {
        [Display(Name = "Email Adresiniz")]
        [Required(ErrorMessage = "Email Alanı zorunludur.")]
        [EmailAddress]
        public string UserMail { get; set; }
        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifre Alanı zorunludur.")]
        public string Password { get; set; }
    }
}
