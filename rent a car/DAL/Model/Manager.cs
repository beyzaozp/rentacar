using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Manager
    {
        public int? Tcno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime? DogumTarih { get; set; }
        public int? CepTel { get; set; }
        public int? EvısTel { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public int? ArabaId { get; set; }
        public int? MusteriId { get; set; }
        public int? CleanerId { get; set; }
        public int ManagerId { get; set; }
        public string Sifre { get; set; }

        public virtual Araba Araba { get; set; }
        public virtual Temizlikçi Cleaner { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Person TcnoNavigation { get; set; }
    }
}
