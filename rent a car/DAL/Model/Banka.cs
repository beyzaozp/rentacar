using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Banka
    {
        public int BankId { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string İletişimBilgileri { get; set; }
    }
}
