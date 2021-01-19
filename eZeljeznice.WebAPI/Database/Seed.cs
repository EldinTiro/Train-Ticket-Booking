using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Database
{
    public class Seed
    {
        public static void Seeding(IB170285Context context)
        {
            context.Database.Migrate();

        }
    }
}
