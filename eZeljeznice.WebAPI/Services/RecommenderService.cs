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

            Putovanja trenutnoPutovanje = _context.Putovanja.Find(putovanjeID);
            

            List<PretragaVM> ocjenePosmatranogPutovanja = new List<PretragaVM>();
            List<Pretrage> ocjeneIzBaze = _context.Pretrage.Where(x => x.RelacijaId == trenutnoPutovanje.RelacijaId).ToList();
            _mapper.Map(ocjeneIzBaze, ocjenePosmatranogPutovanja);

            List<PretragaVM> tmpOcjene1 = new List<PretragaVM>();
            List<PretragaVM> tmpOcjene2 = new List<PretragaVM>();

            List<PutovanjaVM> preporucenaPutovanja = new List<PutovanjaVM>();

            foreach (var item in putovanja)
            {
                foreach (PretragaVM p in ocjenePosmatranogPutovanja)
                {
                    if(item.Value.Where(x => x.KupacId == p.KupacId).Count() > 0)
                    {
                        tmpOcjene1.Add(p);
                        tmpOcjene2.Add(item.Value.Where(x => x.KupacId == p.KupacId).First());
                    }
                }

                double slicnosti = 0;
                slicnosti = GetSlicnost(tmpOcjene1, tmpOcjene2);

                if (slicnosti > 0.99)
                {
                    Putovanja element = _context.Putovanja.Find(item.Key);
                    PutovanjaVM elementPreporuceni = new PutovanjaVM();

                    _mapper.Map(element, elementPreporuceni);

                    elementPreporuceni.Polaziste = _context.Relacije.Where(w => w.RelacijaId == element.RelacijaId).Select(s => s.ZeljeznickaStanicaOd.Naziv).FirstOrDefault();
                    elementPreporuceni.Odrediste = _context.Relacije.Where(w => w.RelacijaId == element.RelacijaId).Select(s => s.ZeljeznickaStanicaDo.Naziv).FirstOrDefault();

                    preporucenaPutovanja.Add(elementPreporuceni);

                }

                tmpOcjene1.Clear();
                tmpOcjene2.Clear();
            }

            return preporucenaPutovanja;

        }

        private double GetSlicnost(List<PretragaVM> tmpOcjene1, List<PretragaVM> tmpOcjene2)
        {
            if (tmpOcjene1.Count != tmpOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < tmpOcjene1.Count; i++)
            {
                brojnik += Convert.ToDouble(tmpOcjene1[i].Ocjena * tmpOcjene2[i].Ocjena);
                nazivnik1 += Convert.ToDouble(tmpOcjene1[i].Ocjena * tmpOcjene2[i].Ocjena);
                nazivnik2 += Convert.ToDouble(tmpOcjene1[i].Ocjena * tmpOcjene2[i].Ocjena);

            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
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
