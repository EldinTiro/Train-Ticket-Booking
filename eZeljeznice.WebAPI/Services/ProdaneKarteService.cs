using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class ProdaneKarteService : IProdaneKarteService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public ProdaneKarteService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ProdanaKartaVM> Get(ProdaneKarteSearchRequest request)
        {
            List<Putovanja> PutovanjaDB = new List<Putovanja>();

            List<ProdanaKartaVM> prodaneKarte = new List<ProdanaKartaVM>();

            List<KupljeneKarte> kupljeneKartes = new List<KupljeneKarte>();

            List<Rezervacije> Rezervacijes = new List<Rezervacije>();

            if (request.PolaznaZeljeznickaStanica == 0 && request.OdredisnaljeznickaStanica == 0)
            {
                kupljeneKartes = _context.KupljeneKarte.Where(w => w.DatumProdaje.Value.Year == request.DatumKarte.Year && w.DatumProdaje.Value.Month == request.DatumKarte.Month && w.DatumProdaje.Value.Day == request.DatumKarte.Day).ToList();
            }
            else
            {
                if (request.PolaznaZeljeznickaStanica != 0)
                {
                    PutovanjaDB = _context.Putovanja.Where(w => w.Relacija.ZeljeznickaStanicaOdid == request.PolaznaZeljeznickaStanica).ToList();

                }
                else
                {
                    PutovanjaDB = _context.Putovanja.Where(w => w.Relacija.ZeljeznickaStanicaDoid == request.OdredisnaljeznickaStanica).ToList();
                }



                foreach (var item in PutovanjaDB)
                {
                    List<Rezervacije> RezervacijesTmp = new List<Rezervacije>();

                    RezervacijesTmp = _context.Rezervacije.Where(w => w.PutovanjeId == item.PutovanjeId).ToList();

                    if (RezervacijesTmp.Count > 0)
                    {
                        Rezervacijes.AddRange(RezervacijesTmp);
                    }


                }


                foreach (var item in Rezervacijes)
                {
                    List<KupljeneKarte> karteTmp = new List<KupljeneKarte>();

                    karteTmp = _context.KupljeneKarte.Where(w => w.RezervacijaId == item.RezervacijaId &&
                    (w.DatumProdaje.Value.Year == request.DatumKarte.Year && w.DatumProdaje.Value.Month == request.DatumKarte.Month && w.DatumProdaje.Value.Day == request.DatumKarte.Day))
                        .ToList();

                    if (karteTmp != null)
                        kupljeneKartes.AddRange(karteTmp);

                }
            }

            foreach (var item in kupljeneKartes)
            {
                ProdanaKartaVM prodanaTemp = new ProdanaKartaVM();

                prodanaTemp.BrojRacuna = item.BrojRacuna;
                prodanaTemp.DatumProdaje = item.DatumProdaje;
                prodanaTemp.Relacija = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Putovanje.Relacija.ZeljeznickaStanicaOd.Naziv +" - "+ s.Putovanje.Relacija.ZeljeznickaStanicaDo.Naziv).FirstOrDefault();
                prodanaTemp.KonacnaCijena = item.KonacnaCijena;
                prodanaTemp.KorisnikId = item.KupacId;
                prodanaTemp.Popust = item.Popust;
                prodanaTemp.ImeKupca = _context.Kupci.Where(w => w.KupacId == item.KupacId).Select(s => s.Ime).FirstOrDefault();
                prodanaTemp.PrezimeKupca = _context.Kupci.Where(w => w.KupacId == item.KupacId).Select(s => s.Prezime).FirstOrDefault();

                prodaneKarte.Add(prodanaTemp);

            }

            return prodaneKarte;

        }

        public ProdanaKartaVM Insert(ProdaneKarteInsertRequest request)
        {
            KupljeneKarte kupljeneKarte = new KupljeneKarte();
            ProdanaKartaVM kupljeneKarteVM = new ProdanaKartaVM();

            _mapper.Map(request, kupljeneKarte);

            try
            {
                _context.Add(kupljeneKarte);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            kupljeneKarteVM.BrojRacuna = kupljeneKarte.BrojRacuna;
            kupljeneKarteVM.DatumProdaje = kupljeneKarte.DatumProdaje;
            kupljeneKarteVM.KonacnaCijena = kupljeneKarte.KonacnaCijena;
            kupljeneKarteVM.KorisnikId = kupljeneKarte.KupacId;
            kupljeneKarteVM.Popust = kupljeneKarte.Popust;
            kupljeneKarteVM.RezervacijaId = kupljeneKarte.RezervacijaId;
            kupljeneKarteVM.ProdanaKartaId = kupljeneKarte.ProdanaKartaId;

            return kupljeneKarteVM;

        }
    }
}
