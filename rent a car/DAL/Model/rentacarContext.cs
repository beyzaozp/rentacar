using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Model
{
    public partial class rentacarContext : DbContext
    {
        public rentacarContext()
        {
        }

        public rentacarContext(DbContextOptions<rentacarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Araba> Araba { get; set; }
        public virtual DbSet<Banka> Banka { get; set; }
        public virtual DbSet<Cost> Cost { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Officer> Officer { get; set; }
        public virtual DbSet<Parabirimi> Parabirimi { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Profit> Profit { get; set; }
        public virtual DbSet<Temizlikçi> Temizlikçi { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=BEYZA;Initial Catalog=rentacar;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>(entity =>
            {
                entity.Property(e => e.ArabaId).HasColumnName("ArabaID");

                entity.Property(e => e.Hasar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kapı)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kilometre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marka)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotorGücü)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plaka)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Renk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vites)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Yakıt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Banka>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_Bank");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.İletişimBilgileri)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.HasKey(e => e.Tarih);

                entity.Property(e => e.Tarih)
                    .HasColumnName("tarih")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArabaId).HasColumnName("ArabaID");

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CleanerId).HasColumnName("CleanerID");

                entity.Property(e => e.DogumTarih).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MusteriId).HasColumnName("MusteriID");

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tcno).HasColumnName("TCno");

                entity.HasOne(d => d.Araba)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.ArabaId)
                    .HasConstraintName("FK_Manager_Araba");

                entity.HasOne(d => d.Cleaner)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.CleanerId)
                    .HasConstraintName("FK_Manager_Cleaner");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.MusteriId)
                    .HasConstraintName("FK_Manager_Musteri");

                entity.HasOne(d => d.TcnoNavigation)
                    .WithMany(p => p.Manager)
                    .HasForeignKey(d => d.Tcno)
                    .HasConstraintName("FK_Manager_Person");
            });

            modelBuilder.Entity<Musteri>(entity =>
            {
                entity.Property(e => e.MusteriId).HasColumnName("MusteriID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarih).HasColumnType("date");

                entity.Property(e => e.EhliyetTuru)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notlar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tcno).HasColumnName("TCno");

                entity.HasOne(d => d.TcnoNavigation)
                    .WithMany(p => p.Musteri)
                    .HasForeignKey(d => d.Tcno)
                    .HasConstraintName("FK_Musteri_Person");
            });

            modelBuilder.Entity<Officer>(entity =>
            {
                entity.Property(e => e.OfficerId).HasColumnName("OfficerID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarih).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StuffId).HasColumnName("StuffID");

                entity.Property(e => e.Tcno).HasColumnName("TCno");

                entity.HasOne(d => d.TcnoNavigation)
                    .WithMany(p => p.Officer)
                    .HasForeignKey(d => d.Tcno)
                    .HasConstraintName("FK_Officer_Person");
            });

            modelBuilder.Entity<Parabirimi>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Tcno);

                entity.Property(e => e.Tcno).HasColumnName("TCno");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarih).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profit>(entity =>
            {
                entity.Property(e => e.ProfitId).HasColumnName("ProfitID");

                entity.Property(e => e.Tarih).HasColumnName("tarih");
            });

            modelBuilder.Entity<Temizlikçi>(entity =>
            {
                entity.HasKey(e => e.CleanerId)
                    .HasName("PK_Cleaner");

                entity.Property(e => e.CleanerId).HasColumnName("CleanerID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cinsiyet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarih).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StuffId).HasColumnName("StuffID");

                entity.Property(e => e.Tcno).HasColumnName("TCno");

                entity.HasOne(d => d.TcnoNavigation)
                    .WithMany(p => p.Temizlikçi)
                    .HasForeignKey(d => d.Tcno)
                    .HasConstraintName("FK_Cleaner_Person");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Sifre)
                    .HasColumnName("sifre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
