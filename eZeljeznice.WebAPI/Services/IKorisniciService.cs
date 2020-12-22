using eZeljeznice.WebAPI.Database;
using System;
using eZeljeznice.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model.Requests;
using eZeljeznice.Model.Responses;

namespace eZeljeznice.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<KorisniciVM> Get(KorisniciSearchRequest request);
        KorisniciVM GetById(int id);
        KorisniciVM Insert(KorisniciInsertRequest request);
        KorisniciVM Update(int id, KorisniciInsertRequest request);
        KorisniciVM Authenticiraj(string username, string pass);
        List<KorisniciLoyaltyResponse> GetLoyalty();
    }
}
