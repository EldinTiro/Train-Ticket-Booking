using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;

namespace eZeljeznice.WebAPI.Services
{
    public interface IPretrageService
    {
        List<PretragaVM> Get();
        PretragaVM Insert(PretragaInsertRequest request);
        PretragaVM Update(int id, PretragaInsertRequest request);
    }
}
