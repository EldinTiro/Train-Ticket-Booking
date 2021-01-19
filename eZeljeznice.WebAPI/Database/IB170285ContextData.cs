using eZeljeznice.WebAPI.Encryption;
using eZeljeznice.WebAPI.Helper;
using eZeljeznice.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Database
{
    public partial class IB170285Context
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            var korisnikLozinkaSalt = HashGenSalt.GenerateSalt();
            var korisnikLozinkaHash = HashGenSalt.GenerateHash(korisnikLozinkaSalt, "test");

            var kupacLozinkaSalt = HashGenSalt.GenerateSalt();
            var kupacLozinkaHash = HashGenSalt.GenerateHash(kupacLozinkaSalt, "test");


            //KORISNICI
            modelBuilder.Entity<Korisnici>().HasData(new Korisnici() {
                KorisnikId = 1,
                Email = "desktop@mail.com",
                Ime = "test",
                Prezime = "test",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "desktop",
                LozinkaSalt = korisnikLozinkaSalt,
                LozinkaHash = korisnikLozinkaHash
            });

            //KUPCI
            modelBuilder.Entity<Kupci>().HasData(new Kupci()
            {
                KupacId = 1,
                Email = "mobile@mail.com",
                Ime = "test",
                Prezime = "test",
                DatumRegistracije = DateTime.Now,
                KorisnickoIme = "mobile",
                LozinkaSalt = kupacLozinkaSalt,
                LozinkaHash = kupacLozinkaHash
            });

            //GRADOVI
            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 1,
                Naziv = "Sarajevo",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 2,
                Naziv = "Mostar",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 3,
                Naziv = "Tuzla",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 4,
                Naziv = "Banja luka",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 5,
                Naziv = "Beograd",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 6,
                Naziv = "Zagreb",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 7,
                Naziv = "Split",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 8,
                Naziv = "Obavještenje za putnike",
                Sadrzaj = "Željeznice FBiH obavještavaju putnike da BH vozovi koji redovno saobraćaju na relacijama Sarajevo-Bihać-Sarajevo i Sarajevo- Banja Luka- Sarajevo do daljnjeg saobraćaju samo na relaciji Sarajevo-Doboj- Sarajevo, zbog vanrednog događaja na dijelu pruge Željeznica Republike Srpske između Doboja i Banja Luke 05.01.2019. godine, kada je došlo do iskakanje iz šina lokalnog putničkog voza Željeznica RS.    Po okončanju posljedica izazvanih ovim vanrednim događajem, ponovo će biti uspostavljena linija Sarajevo-Bihać- Sarajevo i Sarajevo –Banja Luka- Sarajevo.    Putnički saobraćaj na ostalim relacijama odvija se po Redu vožnje ŽFBiH.",
                DatumObjave = DateTime.Now

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 9,
                Naziv = "Putnički voz 2154",
                Sadrzaj = "Željeznice FBiH obavještavaju putnike da se do daljnjeg otkazuje saobraćaj lokalnog putničkog voza 2154 koji je saobraćao na relaciji Sarajevo-Zenica sa polaskom iz Sarajeva u 11:02 h i lokalnog putničkog voza 2155 koji je saobraćao na relaciji Zenica-Sarajevo sa polaskom iz Zenice u 11:07 h.    Saobraćaj ovih vozova otkazuje se zbog izvođenja radova na pruzi, odnosno, zbog radova na ugradnji optičkog kabla na pomenutoj dionici.    O ponovnoj uspostavi saobraćaja navedenih vozova, putnici će biti blagovremeno obaviješteni.",
                DatumObjave = DateTime.Now.AddDays(2)

            });

            modelBuilder.Entity<Gradovi>().HasData(new Gradovi()
            {
                GradId = 10,
                Naziv = "Info o saobraćaju",
                Sadrzaj = "Željeznice Federacije Bosne i Hercegovine od 01.06.2020. godine uspostavljaju željeznički putnički prevoz u lokalnom saobraćaju, a vozovi će voziti u skladu sa izmijenjenim Redom vožnje.",
                DatumObjave = DateTime.Now.AddDays(1)

            });

            //ZELJEZNICKE STANICE
            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 1,
                Email = "ztsarajevo@hotmail.com",
                Naziv = "Ž.S. Sarajevo",
                Adresa = "Halida Kajtaza 10",
                Telefon = "033251251",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 2,
                Email = "zsmostar@hotmail.com",
                Naziv = "Ž.S. Mostar",
                Adresa = "Ložionička 12",
                Telefon = "036565565",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 3,
                Email = "zttuzla@hotmail.com",
                Naziv = "Ž.S. Tuzla",
                Adresa = "Radnička 23",
                Telefon = "035458754",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 4,
                Email = "ztbanjaluka@hotmail.com",
                Naziv = "Ž.S. Banja Luka",
                Adresa = "Trg pobjede 56",
                Telefon = "051478724",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 5,
                Email = "zkzagreb@hotmail.com",
                Naziv = "Ž.S. Zagreb",
                Adresa = "Strojarska cesta 11",
                Telefon = "+385013333200",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 6,
                Email = "zksplit@hotmail.com",
                Naziv = "Ž.S. Split",
                Adresa = "Dubrovačka 11",
                Telefon = "+385078924233",
                GradId = 1
            });

            modelBuilder.Entity<ZeljeznickeStanice>().HasData(new ZeljeznickeStanice()
            {
                ZeljeznickaStanicaId = 7,
                Email = "ztbeograd@hotmail.com",
                Naziv = "Ž.S. Beograd",
                Adresa = "Jurija Gagarina 33",
                Telefon = "+381112222300",
                GradId = 1
            });

            //RELACIJE

            int RelacijaID = 1;
            for (int zod = 1; zod < 8; zod++)
            {
                for (int zdo = 1; zdo < 8; zdo++)
                {
                    if (zod != zdo) 
                    { 
                    modelBuilder.Entity<Relacije>().HasData(new Relacije()
                    {
                        RelacijaId = RelacijaID++,
                        ZeljeznickaStanicaOdid = zod,
                        ZeljeznickaStanicaDoid = zdo

                    });
                    }
                }
            }

            modelBuilder.Entity<Relacije>().HasData(new Relacije()
            {
                RelacijaId = 51,
                ZeljeznickaStanicaOdid = 1,
                ZeljeznickaStanicaDoid = 2

            });

            modelBuilder.Entity<Relacije>().HasData(new Relacije()
            {
                RelacijaId = 52,
                ZeljeznickaStanicaOdid = 1,
                ZeljeznickaStanicaDoid = 2

            });

            modelBuilder.Entity<Relacije>().HasData(new Relacije()
            {
                RelacijaId = 53,
                ZeljeznickaStanicaOdid = 2,
                ZeljeznickaStanicaDoid = 1

            });

            //PUTOVANJA

            int PutovanjeID = 1;
            double cijena = 5;

            int PutovanjeID2 = 43;
            double cijena2 = 5.25;

            int PutovanjeID3 = 85;
            double cijena3 = 7.45;

            for (int i = 1; i < 43; i++)
            {
                cijena = cijena + 0.50;
                modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
                {
                    RelacijaId = i,
                    PutovanjeId = PutovanjeID++,
                    DatumPolaska = DateTime.Today.AddDays(1),
                    VrijemePolaska = new TimeSpan(3, 30, 0),
                    VrijemeDolaska = new TimeSpan(10, 30, 0),
                    Cijena = cijena

                });
            }

            for (int i = 1; i < 43; i++)
            {
                cijena2 = cijena2 + 0.50;
                modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
                {
                    RelacijaId = i,
                    PutovanjeId = PutovanjeID2++,
                    DatumPolaska = DateTime.Today.AddDays(2),
                    VrijemePolaska = new TimeSpan(4, 30, 0),
                    VrijemeDolaska = new TimeSpan(11, 30, 0),
                    Cijena = cijena2 
                });
            }

            for (int i = 1; i < 43; i++)
            {
                cijena3 = cijena3 + 0.50;
                modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
                {
                    RelacijaId = i,
                    PutovanjeId = PutovanjeID3++,
                    DatumPolaska = DateTime.Today.AddDays(3),
                    VrijemePolaska = new TimeSpan(5, 30, 0),
                    VrijemeDolaska = new TimeSpan(12, 30, 0),
                    Cijena = cijena3

                });
            }

            modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
            {
                RelacijaId = 1,
                PutovanjeId = 127,
                DatumPolaska = DateTime.Today.AddDays(3),
                VrijemePolaska = new TimeSpan(5, 30, 0),
                VrijemeDolaska = new TimeSpan(12, 30, 0),
                Cijena = cijena3

            });

            modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
            {
                RelacijaId = 1,
                PutovanjeId = 128,
                DatumPolaska = DateTime.Today.AddDays(3),
                VrijemePolaska = new TimeSpan(5, 30, 0),
                VrijemeDolaska = new TimeSpan(12, 30, 0),
                Cijena = cijena3

            });

            modelBuilder.Entity<Putovanja>().HasData(new Putovanja()
            {
                RelacijaId = 2,
                PutovanjeId = 129,
                DatumPolaska = DateTime.Today.AddDays(3),
                VrijemePolaska = new TimeSpan(5, 30, 0),
                VrijemeDolaska = new TimeSpan(12, 30, 0),
                Cijena = cijena3

            });



            //KARTE
            Random rnd = new Random();
            for (int i = 1; i < 31; i++)
            {
                modelBuilder.Entity<Karte>().HasData(new Karte()
                {
                    KartaId = i,
                    RedniBrojSjedista = rnd.Next(1, 30),
                    RedniBrojVagona = rnd.Next(1, 10)
            });
            }

            //REZERVACIJE
            for (int i = 1; i < 31; i++)
            {
                modelBuilder.Entity<Rezervacije>().HasData(new Rezervacije()
                {
                    RezervacijaId = i,
                    KartaId = i,
                    DatumRezervacije = DateTime.Now,
                    KupacId = 1,
                    PutovanjeId = rnd.Next(1, 126),
                    Kompletirana = true
                });
            }

            //PRODANE KARTE
            for (int i = 1; i < 31; i++)
            {
                modelBuilder.Entity<KupljeneKarte>().HasData(new KupljeneKarte()
                {
                ProdanaKartaId = i,
                BrojRacuna = BrojRacunaHelper.GenerisiBrojRacuna(),
                DatumProdaje = DateTime.Now,
                RezervacijaId = rnd.Next(1, 30),
                Popust = 0,
                KupacId = 1, 
                KonacnaCijena = rnd.Next(1, 77)
            });

            }

            for (int i = 1; i < 100; i++)
            {
                modelBuilder.Entity<Pretrage>().HasData(new Pretrage()
                {
                    RezervacijaID = rnd.Next(1, 30),
                    RelacijaId = rnd.Next(1, 42),
                    KupacId = 1,
                    PretragaId = i,
                    Ocjena = rnd.Next(3, 5)
                });
            }
        }
    }
}
