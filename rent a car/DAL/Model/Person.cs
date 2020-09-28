using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Person
    {
        public Person()
        {
            Manager = new HashSet<Manager>();
            Musteri = new HashSet<Musteri>();
            Officer = new HashSet<Officer>();
            Temizlikçi = new HashSet<Temizlikçi>();
        }

        public int Tcno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime? DogumTarih { get; set; }
        public int? CepTel { get; set; }
        public int? EvısTel { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }

        public virtual ICollection<Manager> Manager { get; set; }
        public virtual ICollection<Musteri> Musteri { get; set; }
        public virtual ICollection<Officer> Officer { get; set; }
        public virtual ICollection<Temizlikçi> Temizlikçi { get; set; }
    }
}
