﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SusiSu.Enums.Enums;

namespace SusiSu.Models
{
    public class ListeleViewModel
    {
        public int SuID { get; set; }

        public Boy   Boy { get; set; }
        public Tur Tur { get; set; }
        public int Quantity { get; set; }
        public int Fiyat { get; set; }
        public ICollection<Su> Su { get; set; }
    }
}