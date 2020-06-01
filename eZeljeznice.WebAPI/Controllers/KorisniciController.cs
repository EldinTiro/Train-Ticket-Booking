using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eZeljeznice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController (IKorisniciService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<KorisniciVM> Get()
        {
            var list = _service.Get();

            return list;
        }
    }
}