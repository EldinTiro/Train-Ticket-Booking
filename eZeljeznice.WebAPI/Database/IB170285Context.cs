using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eZeljeznice.WebAPI.Database
{
    public partial class IB170285Context : DbContext
    {
        public IB170285Context()
        {
        }

        public IB170285Context(DbContextOptions<IB170285Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Karte> Karte { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<KupljeneKarte> KupljeneKarte { get; set; }
        public virtual DbSet<Pretrage> Pretrage { get; set; }
        public virtual DbSet<Putovanja> Putovanja { get; set; }
        public virtual DbSet<Relacije> Relacije { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<ZeljeznickeStanice> ZeljeznickeStanice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=IB170285;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId)
                    .HasName("PK__Gradovi__B0F3C984A618A983");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv).HasMaxLength(30);
            });

            modelBuilder.Entity<Karte>(entity =>
            {
                entity.HasKey(e => e.KartaId)
                    .HasName("PK__Karte__EC3FA98E79DF499B");

                entity.Property(e => e.KartaId).HasColumnName("KartaID");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId)
                    .HasName("PK__Korisnic__80B06D61BA5B40FA");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(15);

                entity.Property(e => e.LozinkaHash).HasMaxLength(150);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(150);

                entity.Property(e => e.Prezime).HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisnici)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Korisnici__GradI__1BFD2C07");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId)
                    .HasName("PK__Kupci__A9593C7BAA97602F");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(15);

                entity.Property(e => e.LozinkaHash).HasMaxLength(150);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(150);

                entity.Property(e => e.Prezime).HasMaxLength(20);
            });

            modelBuilder.Entity<KupljeneKarte>(entity =>
            {
                entity.HasKey(e => e.ProdanaKartaId)
                    .HasName("PK__Kupljene__CB8E62892CC2A10F");

                entity.Property(e => e.ProdanaKartaId).HasColumnName("ProdanaKartaID");

                entity.Property(e => e.BrojRacuna).HasMaxLength(10);

                entity.Property(e => e.DatumProdaje).HasColumnType("date");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.KupljeneKarte)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK__KupljeneK__Kupac__01142BA1");


                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.KupljeneKarte)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK__KupljeneK__Rezer__4F7CD00D");
            });

            modelBuilder.Entity<Pretrage>(entity =>
            {
                entity.HasKey(e => e.PretragaId)
                    .HasName("PK__Pretrage__75C8FA1B23B7AAC2");

                entity.Property(e => e.PretragaId).HasColumnName("PretragaID");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.RelacijaId).HasColumnName("RelacijaID");

                entity.Property(e => e.RezervacijaID).HasColumnName("RezervacijaID");

                entity.Property(e => e.Ocjena).HasColumnName("Ocjena");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Pretrage)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK__Pretrage__KupacI__32E0915F");

                entity.HasOne(d => d.Relacija)
                    .WithMany(p => p.Pretrage)
                    .HasForeignKey(d => d.RelacijaId)
                    .HasConstraintName("FK__Pretrage__Relaci__31EC6D26");

                entity.HasOne(d => d.Rezervacije)
                    .WithMany(p => p.Pretrage)
                    .HasForeignKey(d => d.RezervacijaID)
                    .HasConstraintName("FK__Pretrage__Rezervacije__01142BA1");
            });

            modelBuilder.Entity<Putovanja>(entity =>
            {
                entity.HasKey(e => e.PutovanjeId)
                    .HasName("PK__Putovanj__D47C40F973E85F36");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.Property(e => e.DatumPolaska).HasColumnType("date");

                entity.Property(e => e.RelacijaId).HasColumnName("RelacijaID");

                entity.HasOne(d => d.Relacija)
                    .WithMany(p => p.Putovanja)
                    .HasForeignKey(d => d.RelacijaId)
                    .HasConstraintName("FK__Putovanja__Relac__267ABA7A");
            });

            modelBuilder.Entity<Relacije>(entity =>
            {
                entity.HasKey(e => e.RelacijaId)
                    .HasName("PK__Relacije__545AFBE54D92C334");

                entity.Property(e => e.RelacijaId).HasColumnName("RelacijaID");

                entity.Property(e => e.ZeljeznickaStanicaDoid).HasColumnName("ZeljeznickaStanicaDOID");

                entity.Property(e => e.ZeljeznickaStanicaOdid).HasColumnName("ZeljeznickaStanicaODID");

                entity.HasOne(d => d.ZeljeznickaStanicaDo)
                    .WithMany(p => p.RelacijeZeljeznickaStanicaDo)
                    .HasForeignKey(d => d.ZeljeznickaStanicaDoid)
                    .HasConstraintName("FK__Relacije__Zeljez__164452B1");

                entity.HasOne(d => d.ZeljeznickaStanicaOd)
                    .WithMany(p => p.RelacijeZeljeznickaStanicaOd)
                    .HasForeignKey(d => d.ZeljeznickaStanicaOdid)
                    .HasConstraintName("FK__Relacije__Zeljez__15502E78");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId)
                    .HasName("PK__Rezervac__CABA44FDB6409F3A");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.KartaId).HasColumnName("KartaID");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.PutovanjeId).HasColumnName("PutovanjeID");

                entity.HasOne(d => d.Karta)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KartaId)
                    .HasConstraintName("FK__Rezervaci__Karta__2D27B809");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KupacId)
                    .HasConstraintName("FK__Rezervaci__Kupac__2B3F6F97");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK__Rezervaci__Putov__2C3393D0");
            });

            modelBuilder.Entity<ZeljeznickeStanice>(entity =>
            {
                entity.HasKey(e => e.ZeljeznickaStanicaId)
                    .HasName("PK__Zeljezni__8FEBF7C4CFE3D4D0");

                entity.Property(e => e.ZeljeznickaStanicaId).HasColumnName("ZeljeznickaStanicaID");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(15);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.ZeljeznickeStanice)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Zeljeznic__GradI__1273C1CD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
