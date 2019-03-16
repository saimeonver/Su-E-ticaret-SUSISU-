using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SusiSu.Models
{
    public class SiparisDetay
    {
        [Key]
        public int ID { get; set; }
        public int Adet { get; set; }
        public int Fiyat { get; set; }
        public int SuID { get; set; }
        public virtual Su Su { get; set; }
        public int SiparisID { get; set; }
        public virtual Siparis Siparis { get; set; }
    }
}