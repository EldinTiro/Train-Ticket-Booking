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
    public class PretrageService : IPretrageService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public PretrageService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PretragaVM> Get()
        {
            var list = _context.Pretrage.ToList();

            return _mapper.Map<List<PretragaVM>>(list);
        }

        public PretragaVM Insert(PretragaInsertRequest request)
        {
            PretragaVM dbResponse = new PretragaVM();

            Pretrage dbPretrage = new Pretrage();

            dbPretrage.RelacijaId = request.RelacijaId;
            dbPretrage.RezervacijaID = request.RezervacijaID;
            dbPretrage.KupacId = request.KupacId;

            _context.Pretrage.Add(dbPretrage);
            _context.SaveChanges();

            return _mapper.Map(dbPretrage, dbResponse);
                
        }

        public PretragaVM Update(int id, PretragaInsertRequest request)
        {
            PretragaVM dbResponse = new PretragaVM();

            Pretrage dbPretrage = _context.Pretrage.Where(w => w.RezervacijaID == id).FirstOrDefault();

            dbPretrage.Ocjena = request.Ocjena;

            _context.SaveChanges();

            return _mapper.Map(dbPretrage, dbResponse);

        }
    }
}
