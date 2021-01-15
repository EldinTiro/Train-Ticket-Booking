using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class RezervacijeService : IRezervacijeService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public RezervacijeService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<RezervacijeVM> Get(int kupacID)
        {
            List<RezervacijeVM> kupacRezervacije = new List<RezervacijeVM>();

            List<Rezervacije> kupacRezervacije_db = new List<Rezervacije>();

            kupacRezervacije_db = _context.Rezervacije.Where(w => w.KupacId == kupacID).OrderByDescending(o=> o.Putovanje.DatumPolaska).ThenBy(c=> c.Putovanje.VrijemePolaska).ToList();

            _mapper.Map(kupacRezervacije_db, kupacRezervacije);

            foreach (var item in kupacRezervacije)
            {
                item.ImePutovanja = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId)
                                            .Select(s => s.Relacija.ZeljeznickaStanicaOd.Naziv +" - "+ s.Relacija.ZeljeznickaStanicaDo.Naziv)
                                            .FirstOrDefault();

                item.ImePrezimeKupca = _context.Kupci.Where(w => w.KupacId == kupacID)
                                                     .Select(s => s.Ime + " " + s.Prezime)
                                                     .FirstOrDefault();
                item.Polaziste = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId).Select(s => s.Relacija.ZeljeznickaStanicaOd.Naziv).FirstOrDefault();
                item.Odrediste = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId).Select(s => s.Relacija.ZeljeznickaStanicaDo.Naziv).FirstOrDefault();
                item.DatumPolaska = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId).Select(s => s.DatumPolaska).FirstOrDefault();
                item.VrijemePolaska = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId).Select(s => s.VrijemePolaska).FirstOrDefault().ToString();
                item.VrijemeDolaska = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeId).Select(s => s.VrijemeDolaska).FirstOrDefault().ToString();
                item.KonacnaCijena = _context.KupljeneKarte.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.KonacnaCijena).FirstOrDefault();
                item.BrojKarte = _context.KupljeneKarte.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.BrojRacuna).FirstOrDefault();
            }

            return kupacRezervacije;
        }

        public RezervacijeVM Insert(RezervacijeInsertRequest request)
        {
            Rezervacije rezervacije = new Rezervacije();
            RezervacijeVM rezervacijeVM = new RezervacijeVM();

            _mapper.Map(request, rezervacije);

            try {
                
                _context.Add(rezervacije);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            rezervacijeVM.RezervacijaId = rezervacije.RezervacijaId;
            rezervacijeVM.KartaId = rezervacije.KartaId;
            rezervacijeVM.Kompletirana = rezervacije.Kompletirana;
            rezervacijeVM.PutovanjeId = rezervacije.PutovanjeId;
            rezervacijeVM.KupacId = rezervacije.KupacId;
            rezervacijeVM.DatumRezervacije = rezervacije.DatumRezervacije;

            return rezervacijeVM;


        }
    }
}
