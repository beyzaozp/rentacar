using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Profit
    {
        public int ProfitId { get; set; }
        public int? AraçGelir { get; set; }
        public int? Tarih { get; set; }
    }
}
