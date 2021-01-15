using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;

namespace eZeljeznice.WebAPI.Services
{
    public interface IGradoviService
    {
        List<GradoviVM> Get();
        GradoviVM GetById(int id);
        GradoviVM Insert(ObavjestenjeInsertRequest request);
    }
}
