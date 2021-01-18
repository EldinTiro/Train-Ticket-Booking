using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class ObavjestenjeService : IObavjestenjaService
    {

        private readonly IB170285Context _context;
        private readonly IMapper _mapper;
        public List<ObavjestenjeVM> Get()
        {
            var list = _context.Obavjestenja.ToList();

            return _mapper.Map<List<ObavjestenjeVM>>(list);
        }

    }
}
