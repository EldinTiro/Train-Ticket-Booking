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
    public class KarteService : IKarteService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public KarteService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public KarteVM Insert(KartaInsertRequest request)
        {
            Karte karte = new Karte();
            KarteVM karteVM = new KarteVM();

            _mapper.Map(request, karte);

            try
            {

                _context.Add(karte);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            karteVM.KartaId = karte.KartaId;
            karteVM.RedniBrojSjedista = karte.RedniBrojSjedista;
            karteVM.RedniBrojVagona = karte.RedniBrojVagona;

            return karteVM;

        }
    }
}
