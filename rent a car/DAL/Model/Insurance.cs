using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Insurance
    {
        public int InsuranceId { get; set; }
        public string Text { get; set; }
        public string Tarih { get; set; }
        public string CompanyName { get; set; }
    }
}
