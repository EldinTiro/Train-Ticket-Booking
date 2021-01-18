using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public interface IKarteService
    {
        KarteVM Insert(KartaInsertRequest request);
    }
}
