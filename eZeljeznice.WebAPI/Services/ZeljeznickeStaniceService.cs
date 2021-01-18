using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class ZeljeznickeStaniceService : IZeljeznickeStaniceService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public ZeljeznickeStaniceService (IB170285Context context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public ZeljeznickeStaniceVM GetById(int ZeljeznickaStanicaID)
        {

            var list = _context.ZeljeznickeStanice.Find(ZeljeznickaStanicaID);

            return _mapper.Map<ZeljeznickeStaniceVM>(list);
        }

        List<ZeljeznickeStaniceVM> IZeljeznickeStaniceService.Get()
        {
            var list = _context.ZeljeznickeStanice.ToList();

            return _mapper.Map<List<ZeljeznickeStaniceVM>>(list);
        }
    }
}
