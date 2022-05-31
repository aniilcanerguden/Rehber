using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.ViewModel
{
   public class RehberModel
    {
        [Display(Name = "Email Adresiniz")]
        [Required(ErrorMessage = "İsim Alanı zorunludur.")]
        public string Rehberİsim { get; set; }

        [Required(ErrorMessage = "Soyisim Alanı zorunludur.")]
        public string Soyisim { get; set; }
        public int UserID{ get; set; }

        public int ID { get; set; }
        [Required(ErrorMessage = "Telno Alanı zorunludur.")]
        public string Telno { get; set; }
        
    }
}
