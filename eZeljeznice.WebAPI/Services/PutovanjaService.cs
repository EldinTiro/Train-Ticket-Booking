using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class PutovanjaService : IPutovanjaService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public PutovanjaService(IB170285Context context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public List<PutovanjaVM> Get(PutovanjaSearchRequest request)
        {
            var query = _context.Putovanja.AsQueryable();


            if (request.VrijemePolaska != null)
            {
                query = query.Where(x => x.DatumPolaska == request.VrijemePolaska.Date);
            }

            if (!string.IsNullOrWhiteSpace(request?.ZeljeznickaOdID) && request.ZeljeznickaOdID != "0")
            {
                query = query.Where(x => x.Relacija.ZeljeznickaStanicaOdid.ToString() == request.ZeljeznickaOdID);
            }

            if (!string.IsNullOrWhiteSpace(request?.ZeljeznickaDoID) && request.ZeljeznickaDoID != "0")
            {
                query = query.Where(x => x.Relacija.ZeljeznickaStanicaDoid.ToString() == request.ZeljeznickaDoID);
            }

            var list = query.ToList();

            var result = _mapper.Map<List<PutovanjaVM>>(list);

            foreach (var item in result)
            {
                item.Polaziste = _context.Relacije.Where(w => w.RelacijaId == item.RelacijaID).Select(s => s.ZeljeznickaStanicaOd.Naziv).FirstOrDefault();
                item.Odrediste = _context.Relacije.Where(w => w.RelacijaId == item.RelacijaID).Select(s => s.ZeljeznickaStanicaDo.Naziv).FirstOrDefault();
                item.VrijemePolaska = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeID).Select(e => e.VrijemePolaska).FirstOrDefault().ToString();
                item.VrijemeDolaska = _context.Putovanja.Where(w => w.PutovanjeId == item.PutovanjeID).Select(e => e.VrijemeDolaska).FirstOrDefault().ToString();
                //item.ProsjecnaOcjena = _context.Pretrage.Where(p => p.RelacijaId == item.RelacijaID).Select(s => s.Ocjena).ToList().Average();
            }

            return result;
        }

        public List<RelacijeTopSearchResponse> GetTopRelations()
        {
            var top5 = _context.Putovanja
                .GroupBy(q => q.RelacijaId)
                .OrderByDescending(gp => gp.Count())
                .Take(5)
                .Select(g => g.Key)
                .ToList();

            List<Relacije> relacije = new List<Relacije>();

            foreach (var item in top5)
            {
                Relacije rel = _context.Relacije.Where(w => w.RelacijaId == item.Value).FirstOrDefault();
                relacije.Add(rel);
            }

            //var relacije = _context.Relacije.Where(w => top5.Contains(w.RelacijaId)).ToList();

            List<RelacijeTopSearchResponse> response = new List<RelacijeTopSearchResponse>();

            foreach (var item in relacije)
            {
                response.Add(new RelacijeTopSearchResponse()
                {
                    NazivRelacije = (_context.ZeljeznickeStanice.Where(w => w.ZeljeznickaStanicaId == item.ZeljeznickaStanicaOdid).Select(s => s.Naziv).FirstOrDefault()
                    +"   -    "+ _context.ZeljeznickeStanice.Where(w => w.ZeljeznickaStanicaId == item.ZeljeznickaStanicaDoid).Select(s => s.Naziv).FirstOrDefault()),
                    BrojRelacija = _context.Putovanja.Where(w => w.RelacijaId == item.RelacijaId).Count(),
                });
                
            }
            return response;
        }

        public PutovanjaVM Insert(PutovanjaInsertRequest request)
        {
            Relacije entityRelation = new Relacije
            {
                ZeljeznickaStanicaDoid = request.ZeljeznickaStanicaDOID,
                ZeljeznickaStanicaOdid = request.ZeljeznickaStanicaODID
            };
            _context.Add(entityRelation);
            _context.SaveChanges();

            request.RelacijaId = entityRelation.RelacijaId;

            Putovanja entityPutovanje = new Putovanja
            {
                Cijena = request.Cijena,
                DatumPolaska = request.DatumPolaska,
                RelacijaId = request.RelacijaId,
                VrijemeDolaska = request.VrijemeDolaska.Value.TimeOfDay,
                VrijemePolaska = request.VrijemePolaska.Value.TimeOfDay
            };

            _context.Add(entityPutovanje);
            _context.SaveChanges();

            return _mapper.Map<PutovanjaVM>(entityPutovanje);
        }

        public PutovanjaVM Update(int id, PutovanjaInsertRequest request)
        {
            throw new NotImplementedException();
        }

        public List<string> UpdateAkcija(PutovanjaAkcijaRequest request)
        {
            List<string> putovanjaID = new List<string>();

            if (request != null)
            {
                //List<int> relationIDs = _context.Relacije.Where(w => w.ZeljeznickaStanicaOdid == request.ZeljeznickaStanicaODID
                // && w.ZeljeznickaStanicaDoid == request.ZeljeznickaStanicaDOID).Select(s => s.RelacijaId).ToList();

                if (request.ZeljeznickaStanicaDOID == 0)
                {
                    request.ZeljeznickaStanicaDOID = null;
                }

                if (request.ZeljeznickaStanicaODID == 0)
                {
                    request.ZeljeznickaStanicaODID = null;
                }

                List<int> relationIDs = _context.Relacije.Where(w => (request.ZeljeznickaStanicaODID == null || request.ZeljeznickaStanicaODID == w.ZeljeznickaStanicaOdid) &&
                    (request.ZeljeznickaStanicaDOID == null || request.ZeljeznickaStanicaDOID == w.ZeljeznickaStanicaDoid)).Select(s => s.RelacijaId).ToList();


                List<Putovanja> putovanja = new List<Putovanja>();

                if (relationIDs != null)
                {
                    putovanja = _context.Putovanja.Where(w => relationIDs.Contains((int)w.RelacijaId) &&
                    w.DatumPolaska>request.AkcijaOD && w.DatumPolaska<request.AkcijaDO).ToList();
                }

                if (putovanja != null)
                {
                    foreach (var putovanje in putovanja)
                    {
                        putovanje.Cijena = putovanje.Cijena - (putovanje.Cijena * (request.VrijednostAkcije / 100));
                        putovanjaID.Add(putovanje.ToString());
                    }
                    _context.Putovanja.UpdateRange(putovanja);
                    _context.SaveChanges();
                }

            }

            return putovanjaID;
        }
    }
}
