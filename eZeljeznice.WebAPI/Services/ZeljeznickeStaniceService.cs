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

        public ZeljeznickeStaniceService (IB170285Context context)
        {
            this._context = context;
        }
        public List<Database.ZeljeznickeStanice> Get()
        {
            //var list = new List<ZeljeznickeStanice>()
            //{
            //    new ZeljeznickeStanice()
            //    {
            //        Naziv="Sarajevo",
            //        ZeljeznickaStanicaID = 1
            //    },
            //    new ZeljeznickeStanice()
            //    {
            //        Naziv ="Mostar",
            //        ZeljeznickaStanicaID = 2
            //    }
            //};

            
            return _context.ZeljeznickeStanice.ToList();
        }
    }
}
