using eZeljeznice.WebAPI.Database;
using System;
using eZeljeznice.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model.Requests;

namespace eZeljeznice.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<KorisniciVM> Get();

        KorisniciVM Insert(KorisniciInsertRequest request);

    }
}
