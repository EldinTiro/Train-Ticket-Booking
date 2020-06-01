using AutoMapper;
using eZeljeznice.Model;
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
            CreateMap<ZeljeznickeStanice, ZeljeznickeStaniceVM>();
        }
    }
}
