using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Cost
    {
        public DateTime Tarih { get; set; }
        public int? Yakıt { get; set; }
        public int? ArabaMasrafları { get; set; }
        public int? Maaş { get; set; }
        public int? Diğer { get; set; }
    }
}
