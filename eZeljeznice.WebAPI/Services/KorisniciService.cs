using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;
        public KorisniciService (IB170285Context context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        public List<KorisniciVM> Get()
        {
            var list = _context.Korisnici.ToList();

            return _mapper.Map<List<KorisniciVM>>(list);
        }

        public KorisniciVM Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Korisnici>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu!");
            }

            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<KorisniciVM>(entity);

        }
    }
}
