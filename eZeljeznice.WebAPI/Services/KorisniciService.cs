using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.Model.Responses;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public List<KorisniciVM> Get(KorisniciSearchRequest request)
        {

            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime) || x.Prezime.StartsWith(request.Ime));
            }

            /*if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }*/

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

            KorisniciVM korisnik = new KorisniciVM(); 

            if (request.Password != request.PasswordConfirmation)
            {
                korisnik.KorisnikId = 100;
                return korisnik;
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            Korisnici checkExists = _context.Korisnici.Where(w => w.KorisnickoIme == request.KorisnickoIme).FirstOrDefault();

            if (checkExists != null)
            {
                korisnik.KorisnikId = 200;
                return korisnik;
                //throw new UserException("Korisnik pod korisničkim imenom : " + request.KorisnickoIme + " već postoji!");
            }

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

        public List<KorisniciLoyaltyResponse> GetLoyalty()
        {
            var brojKarata = _context.KupljeneKarte.GroupBy(g => g.KupacId).Select(s => new { ID = s.Key, Count = s.Count()}).Where(w=> w.Count>5).OrderBy(o => o.Count).ToList();

            List<KorisniciLoyaltyResponse> loyaltyKorisnici = new List<KorisniciLoyaltyResponse>();

            foreach (var item in brojKarata)
            {
                loyaltyKorisnici.Add(new KorisniciLoyaltyResponse()
                {
                    KorisnikID = (int)item.ID,
                    BrojKupljenihKarata = item.Count,
                    DatumRegistracije = _context.Kupci.Where(w => w.KupacId == item.ID).Select(s => s.DatumRegistracije).FirstOrDefault(),
                    Email = _context.Kupci.Where(w => w.KupacId == item.ID).Select(s => s.Email).FirstOrDefault(),
                    Ime = _context.Kupci.Where(w => w.KupacId == item.ID).Select(s => s.Ime).FirstOrDefault(),
                    Prezime = _context.Kupci.Where(w => w.KupacId == item.ID).Select(s => s.Prezime).FirstOrDefault()
                });
            }

            foreach (var item in loyaltyKorisnici)
            {
                if (item.BrojKupljenihKarata > 5 && item.BrojKupljenihKarata < 10)
                {
                    item.OstvareniPopust = 10;
                }
                else if (item.BrojKupljenihKarata > 10 && item.BrojKupljenihKarata < 20)
                {
                    item.OstvareniPopust = 15;
                }
                else if (item.BrojKupljenihKarata > 20)
                {
                    item.OstvareniPopust = 20;
                }

                _context.KupljeneKarte.Where(f => f.KupacId == item.KorisnikID).ToList().ForEach(cc => cc.Popust = item.OstvareniPopust);
                _context.SaveChanges();

            }

            return loyaltyKorisnici;
        }


    }
}
