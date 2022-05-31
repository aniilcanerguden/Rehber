using FluentValidation;
using Rehber.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.Model
{
   public class Rehberr:BaseEntity
    {
       
        public string Telno { get; set; }
        
        public string Rehberİsim { get; set; }
        
        public string Soyisim { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

    }
   

}
