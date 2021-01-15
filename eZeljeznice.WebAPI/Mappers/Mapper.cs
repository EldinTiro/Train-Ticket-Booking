using AutoMapper;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Korisnici, KorisniciVM>();
            CreateMap<Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<ZeljeznickeStanice, ZeljeznickeStaniceVM>();
            CreateMap<Putovanja, PutovanjaVM>();
            CreateMap<Putovanja, PutovanjaInsertRequest>().ReverseMap();
            CreateMap<Gradovi, GradoviVM>();
            CreateMap<Kupci, KupciVM>();
            CreateMap<Kupci, KupciInsertRequest>().ReverseMap();
            CreateMap<Pretrage, PretragaVM>();
            CreateMap<Rezervacije, RezervacijeVM>();
            CreateMap<Rezervacije, RezervacijeInsertRequest>().ReverseMap();
            CreateMap<Karte, KarteVM>();
            CreateMap<Karte, KartaInsertRequest>().ReverseMap();
            CreateMap<KupljeneKarte, ProdanaKartaVM>();
            CreateMap<KupljeneKarte, ProdaneKarteInsertRequest>().ReverseMap();
            CreateMap<Obavjestenja, ObavjestenjeVM>();

        }
    }
}
