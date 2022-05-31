using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.Entity.Abstract
{
   public abstract class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public bool Durum { get; set; }

        public DateTime? DateTime { get; set; }
        public DateTime? GirisDatetime { get; set; }
        public DateTime? CikisDatetime { get; set; }
        public DateTime? SilindiDatetime { get; set; }
    }
}
