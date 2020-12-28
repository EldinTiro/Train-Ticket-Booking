using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;

namespace eZeljeznice.WebAPI.Services
{
    public interface IPretrageService
    {
        List<PretragaVM> Get();
    }
}
