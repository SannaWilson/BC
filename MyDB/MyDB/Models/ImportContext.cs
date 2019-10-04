using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyDB.Models
{
    public partial class ImportContext : DbContext
    {
        public ImportContext()
        {
        }

        public ImportContext(DbContextOptions<ImportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pakkaus0> Pakkaus0 { get; set; }

        // Unable to generate entity type for table 'dbo.laakemuoto'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.laakeaine'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.atc'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-8IA26QT6\\SQLEXPRESS;Database=Import;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pakkaus0>(entity =>
            {
                entity.HasKey(e => e.Pakkausnro);

                entity.ToTable("pakkaus_0");

                entity.Property(e => e.Pakkausnro)
                    .HasColumnName("PAKKAUSNRO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Astiatun).HasColumnName("ASTIATUN");

                entity.Property(e => e.Atckoodi)
                    .IsRequired()
                    .HasColumnName("ATCKOODI")
                    .HasMaxLength(50);

                entity.Property(e => e.Atctun).HasColumnName("ATCTUN");

                entity.Property(e => e.Ddd)
                    .HasColumnName("DDD")
                    .HasMaxLength(50);

                entity.Property(e => e.Dddyksikko)
                    .HasColumnName("DDDYKSIKKO")
                    .HasMaxLength(50);

                entity.Property(e => e.EdellinenLaakenimi)
                    .HasColumnName("EDELLINEN_LAAKENIMI")
                    .HasMaxLength(100);

                entity.Property(e => e.EdellinenVnrnro)
                    .HasColumnName("EDELLINEN_VNRNRO")
                    .HasMaxLength(50);

                entity.Property(e => e.Ehtokoodi).HasColumnName("EHTOKOODI");

                entity.Property(e => e.Eumyyntilupanro)
                    .HasColumnName("EUMYYNTILUPANRO")
                    .HasMaxLength(50);

                entity.Property(e => e.Haltija)
                    .IsRequired()
                    .HasColumnName("HALTIJA")
                    .HasMaxLength(100);

                entity.Property(e => e.Hum)
                    .IsRequired()
                    .HasColumnName("HUM")
                    .HasMaxLength(1);

                entity.Property(e => e.Huume)
                    .HasColumnName("HUUME")
                    .HasMaxLength(50);

                entity.Property(e => e.Kaupan).HasColumnName("KAUPAN");

                entity.Property(e => e.Kaupastapoispvm)
                    .HasColumnName("KAUPASTAPOISPVM")
                    .HasColumnType("date");

                entity.Property(e => e.Kauppaantulopvm)
                    .HasColumnName("KAUPPAANTULOPVM")
                    .HasColumnType("date");

                entity.Property(e => e.Kerroin).HasColumnName("KERROIN");

                entity.Property(e => e.Koko).HasColumnName("KOKO");

                entity.Property(e => e.Laakemuotonimi)
                    .IsRequired()
                    .HasColumnName("LAAKEMUOTONIMI")
                    .HasMaxLength(100);

                entity.Property(e => e.Laakemuototun).HasColumnName("LAAKEMUOTOTUN");

                entity.Property(e => e.Laakenimi)
                    .IsRequired()
                    .HasColumnName("LAAKENIMI")
                    .HasMaxLength(100);

                entity.Property(e => e.Laite)
                    .HasColumnName("LAITE")
                    .HasMaxLength(50);

                entity.Property(e => e.Liikennevaara).HasColumnName("LIIKENNEVAARA");

                entity.Property(e => e.Muutos)
                    .HasColumnName("MUUTOS")
                    .HasMaxLength(50);

                entity.Property(e => e.Myyntilupanro).HasColumnName("MYYNTILUPANRO");

                entity.Property(e => e.Paatospvm)
                    .HasColumnName("PAATOSPVM")
                    .HasColumnType("date");

                entity.Property(e => e.Paattymispvm)
                    .HasColumnName("PAATTYMISPVM")
                    .HasColumnType("date");

                entity.Property(e => e.Pakkauskoko)
                    .IsRequired()
                    .HasColumnName("PAKKAUSKOKO")
                    .HasMaxLength(50);

                entity.Property(e => e.Psykoluokitus)
                    .HasColumnName("PSYKOLUOKITUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Reseptistatus)
                    .IsRequired()
                    .HasColumnName("RESEPTISTATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Rinnakkaistuonti).HasColumnName("RINNAKKAISTUONTI");

                entity.Property(e => e.Substituutioryhma)
                    .HasColumnName("SUBSTITUUTIORYHMA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tilakoodi).HasColumnName("TILAKOODI");

                entity.Property(e => e.Tilanimi)
                    .IsRequired()
                    .HasColumnName("TILANIMI")
                    .HasMaxLength(50);

                entity.Property(e => e.Vahvuus)
                    .HasColumnName("VAHVUUS")
                    .HasMaxLength(50);

                entity.Property(e => e.Vaikainelkm).HasColumnName("VAIKAINELKM");

                entity.Property(e => e.Vet)
                    .IsRequired()
                    .HasColumnName("VET")
                    .HasMaxLength(1);

                entity.Property(e => e.Vnrnro)
                    .HasColumnName("VNRNRO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Yksikko)
                    .HasColumnName("YKSIKKO")
                    .HasMaxLength(50);
            });
        }
    }
}
