using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Musteri
    {
        public Musteri()
        {
            Manager = new HashSet<Manager>();
        }

        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public int? Tcno { get; set; }
        public DateTime? DogumTarih { get; set; }
        public int? CepTel { get; set; }
        public int? EvısTel { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public int? EhliyetNo { get; set; }
        public string EhliyetTuru { get; set; }
        public string Notlar { get; set; }

        public virtual Person TcnoNavigation { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
    }
}
