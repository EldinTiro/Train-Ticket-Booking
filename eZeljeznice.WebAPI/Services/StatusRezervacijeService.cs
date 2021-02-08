using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class StatusRezervacijeService : IStatusRezervacijeService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public StatusRezervacijeService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<NekompletiraneRezervacijeResponse> Get()
        {
            List<Rezervacije> rezervacijes = _context.Rezervacije.Where(w => w.Kompletirana == false).ToList();
            List<NekompletiraneRezervacijeResponse> responses = new List<NekompletiraneRezervacijeResponse>();

            if (rezervacijes.Count > 0)
            {
                foreach (var item in rezervacijes)
                {
                    NekompletiraneRezervacijeResponse unit = new NekompletiraneRezervacijeResponse();

                    unit.RezervacijaID = item.RezervacijaId;
                    unit.DatumRezervacije = item.DatumRezervacije;
                    unit.Kompletirana = item.Kompletirana;
                    unit.KonacnaCijena = _context.KupljeneKarte.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.KonacnaCijena).FirstOrDefault();
                    unit.ImePrezimeKupca = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Kupac.Ime + " " + s.Kupac.Prezime).FirstOrDefault();
                    unit.DatumPolaska = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Putovanje.DatumPolaska).FirstOrDefault();
                    unit.VrijemeDolaska = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Putovanje.VrijemeDolaska.ToString()).FirstOrDefault();
                    unit.VrijemePolaska = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Putovanje.VrijemePolaska.ToString()).FirstOrDefault();
                    unit.ImePutovanja = _context.Rezervacije.Where(w => w.RezervacijaId == item.RezervacijaId).Select(s => s.Putovanje.Relacija.ZeljeznickaStanicaOd.Naziv + " - " + s.Putovanje.Relacija.ZeljeznickaStanicaDo.Naziv).First();

                    if(unit != null && unit.KonacnaCijena != null)
                    {
                        responses.Add(unit);
                    }
                }
            }

            return responses;
        }

        public RezervacijeVM Update(RezervacijeVM request)
        {

            Rezervacije rezervacije = _context.Rezervacije.Find(request.RezervacijaId);

            RezervacijeVM rezervacijeVM = new RezervacijeVM();

            if (rezervacije != null)
            {
                rezervacije.Kompletirana = true;
                _context.SaveChanges();

                _mapper.Map(rezervacije, rezervacijeVM);
            }

            return rezervacijeVM;
        }
    }
}
