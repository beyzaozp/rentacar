using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Araba
    {
        public Araba()
        {
            Manager = new HashSet<Manager>();
        }

        public int ArabaId { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int? Yıl { get; set; }
        public string Yakıt { get; set; }
        public string Vites { get; set; }
        public string Kilometre { get; set; }
        public string MotorGücü { get; set; }
        public string Kapı { get; set; }
        public string Renk { get; set; }
        public string Hasar { get; set; }

        public virtual ICollection<Manager> Manager { get; set; }
    }
}
