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
    public class ProdaneKarteService : IProdaneKarteService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public ProdaneKarteService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
