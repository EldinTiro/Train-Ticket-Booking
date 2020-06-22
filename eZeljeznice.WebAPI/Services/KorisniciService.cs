using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public List<KorisniciVM> Get(KorisniciSearchRequest request)
        {

            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();

            return _mapper.Map<List<KorisniciVM>>(list);
        }

        public KorisniciVM GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<KorisniciVM>(entity);
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

        public KorisniciVM Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            _mapper.Map(request, entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            { 
                if(request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne slažu");
                }
                //TODO: update password
            }

            _context.SaveChanges();

            return _mapper.Map<KorisniciVM>(entity);

        }
    }
}
