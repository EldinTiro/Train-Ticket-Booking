using eZeljeznice.Model;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Obavjestenja : ControllerBase
    {
        private readonly IObavjestenjaService _service;
        public Obavjestenja(IObavjestenjaService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<ObavjestenjeVM> Get()
        {
            var list = _service.Get();

            return list;
        }
    }
}