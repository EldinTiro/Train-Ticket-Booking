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
