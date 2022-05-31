using Rehber.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.Model
{
   public class User:BaseEntity
    {
        public User()
        {
            Rehbers = new Collection<Rehberr>();
        }

        public string userMail { get; set; }
        
        
        public string password { get; set; }
       
        public ICollection<Rehberr> Rehbers { get; set; }
    }
}
