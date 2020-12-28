using AutoMapper;
using eZeljeznice.Model;
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
    }
}
