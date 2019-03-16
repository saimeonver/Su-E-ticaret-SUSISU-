using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SusiSu.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public  IEnumerable<SiparisDetay> SiparisDetays { get; set; }
        public virtual User User { get; set; }
    }
}