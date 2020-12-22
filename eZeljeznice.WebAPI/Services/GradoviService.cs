using AutoMapper;
using eZeljeznice.Model;
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
            var list = _context.Gradovi.ToList();

            return _mapper.Map<List<GradoviVM>>(list);
        }

        public GradoviVM GetById(int gradID)
        {
            var list = _context.Gradovi.Find(gradID);

            return _mapper.Map<GradoviVM>(list);
        }
    }
}
