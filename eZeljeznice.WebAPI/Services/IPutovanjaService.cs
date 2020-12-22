using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model.Requests;

namespace eZeljeznice.WebAPI.Services
{
    public interface IPutovanjaService
    {
        List<PutovanjaVM> Get(PutovanjaSearchRequest request);
        PutovanjaVM Insert(PutovanjaInsertRequest request);
        PutovanjaVM Update(int id, PutovanjaInsertRequest request);
        List<string> UpdateAkcija(PutovanjaAkcijaRequest request);
        List<RelacijeTopSearchResponse> GetTopRelations();
    }
}
