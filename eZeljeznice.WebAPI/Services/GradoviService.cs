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
    public class GradoviService : IGradoviService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public GradoviService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GradoviVM> Get()
        {
            List<Gradovi> list = _context.Gradovi.OrderByDescending(ord => ord.DatumObjave).ToList();

            List<GradoviVM> vmList = new List<GradoviVM>();

            foreach (var item in list)
            {
                if (item.Sadrzaj != null)
                {
                    GradoviVM vmItem = new GradoviVM();
                    vmList.Add(_mapper.Map(item, vmItem));
                }
            }

            return vmList;
        }

        public GradoviVM GetById(int gradID)
        {
            var list = _context.Gradovi.Find(gradID);

            return _mapper.Map<GradoviVM>(list);
        }

        public GradoviVM Insert(ObavjestenjeInsertRequest request)
        {
            Gradovi novoObavjestenje = new Gradovi();

            GradoviVM gradoviVM = new GradoviVM();

            if (request != null)
            {
                novoObavjestenje.Naziv = request.Naziv;
                novoObavjestenje.Sadrzaj = request.Sadrzaj;
                novoObavjestenje.DatumObjave = request.DatumObjave;

                _context.Gradovi.Add(novoObavjestenje);
                _context.SaveChanges();

                return _mapper.Map(novoObavjestenje, gradoviVM);
            }
            else
                return gradoviVM;
        }
    }
}
