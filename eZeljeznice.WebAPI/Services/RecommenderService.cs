using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class RecommenderService : IRecommender
    {
        Dictionary<int, List<PretragaVM>> putovanja = new Dictionary<int, List<PretragaVM>>();

        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public RecommenderService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PutovanjaVM> GetSlicnaPutovanja(int putovanjeID)
        {
            UcitajPutovanja(putovanjeID);
            throw new NotImplementedException();
        }

        private void UcitajPutovanja(int putovanjeID)
        {
            var relacijaPutovanja = _context.Putovanja.Find(putovanjeID).RelacijaId;
            List<Putovanja> aktivnaPutovanja = _context.Putovanja.Where(x => x.RelacijaId != relacijaPutovanja).ToList();

            Putovanja posmatranoPutovanje = _context.Putovanja.Find(putovanjeID);

            List<PutovanjaVM> novaLista = new List<PutovanjaVM>();
            _mapper.Map(aktivnaPutovanja, novaLista);

            List<PutovanjaVM> listaKonacna = new List<PutovanjaVM>();

            foreach (var item in novaLista)
            {
                if (_context.Relacije.Find(item.RelacijaID).ZeljeznickaStanicaOdid == _context.Relacije.Find(posmatranoPutovanje.RelacijaId).ZeljeznickaStanicaOdid)
                {
                    listaKonacna.Add(item);
                }
            }

            foreach (var item in listaKonacna)
            {
                List<Pretrage> listaPretragaOcjena = _context.Pretrage.Where(x => x.RelacijaId == item.RelacijaID).ToList();
                List<PretragaVM> pretragaOcjene = new List<PretragaVM>();
                foreach (var item2 in listaPretragaOcjena)
                {
                    PretragaVM pretraga = new PretragaVM();
                    pretraga.KupacId = item2.KupacId;
                    pretraga.Ocjena = item2.Ocjena;
                    pretraga.PretragaId = item2.PretragaId;
                    pretraga.RelacijaId = item2.RelacijaId;

                    pretragaOcjene.Add(pretraga);
                }

                if (pretragaOcjene.Count > 0)
                    putovanja.Add(item.PutovanjeID, pretragaOcjene);
            }
        }
    }
}
