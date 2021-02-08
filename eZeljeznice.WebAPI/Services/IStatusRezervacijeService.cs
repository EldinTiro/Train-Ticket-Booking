using eZeljeznice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Services
{
    public interface IStatusRezervacijeService
    {
        List<NekompletiraneRezervacijeResponse> Get();

        RezervacijeVM Update(RezervacijeVM request);
    }
}
