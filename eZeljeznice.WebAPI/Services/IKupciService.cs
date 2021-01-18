using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public interface IKupciService
    {
        List<KupciVM> Get(KupciSearchRequest request);
        KupciVM GetById(int id);
        void Insert(KupciInsertRequest request);
        KupciVM Update(int id, KupciUpdateRequest request);
        KupciVM Authenticiraj(string username, string password);
    }
}
