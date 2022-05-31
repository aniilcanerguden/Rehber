using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.ViewModel
{
   public class UserRegister
    {

        [Required(ErrorMessage = "Email adresi zorunludur.")]
        [Display(Name = "Email Adresi")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil.")]
        public string UserMail{ get; set; }
       
        [Required(ErrorMessage = "Şifre girmek zorunludur.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
