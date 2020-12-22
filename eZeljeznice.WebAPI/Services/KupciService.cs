using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public class KupciService : IKupciService
    {
        private readonly IB170285Context _context;
        private readonly IMapper _mapper;

        public KupciService(IB170285Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public KorisniciVM Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<KorisniciVM>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<KupciVM> Get(KupciSearchRequest request)
        {
            var query = _context.Kupci.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime) || x.Prezime.StartsWith(request.Ime));
            }

            var list = query.ToList();

            return _mapper.Map<List<KupciVM>>(list);
        }

        public KupciVM GetById(int id)
        {
            var entity = _context.Kupci.Find(id);

            return _mapper.Map<KupciVM>(entity);
        }

        public KupciVM Insert(KupciInsertRequest request)
        {
            var entity = _mapper.Map<KupciVM>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu!");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<KupciVM>(entity);
        }

        public KupciVM Update(int id, KupciInsertRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
