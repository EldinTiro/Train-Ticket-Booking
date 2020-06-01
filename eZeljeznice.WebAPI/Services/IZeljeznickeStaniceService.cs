using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public interface IZeljeznickeStaniceService
    {
        List<Database.ZeljeznickeStanice> Get();
    }
}
