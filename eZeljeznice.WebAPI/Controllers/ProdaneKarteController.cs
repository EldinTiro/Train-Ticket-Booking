using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdaneKarteController : ControllerBase
    {
        private readonly IProdaneKarteService _service;

        public ProdaneKarteController(IProdaneKarteService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<ProdanaKartaVM> Get([FromQuery]ProdaneKarteSearchRequest request)
        {
            var list = _service.Get(request);

            return list;
        }

        [HttpPost]
        public ProdanaKartaVM Insert(ProdaneKarteInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
