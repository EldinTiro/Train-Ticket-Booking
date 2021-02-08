using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Services;
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
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;

        public RezervacijeController(IRezervacijeService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<RezervacijeVM> Get(int id)
        {
            var list = _service.Get(id);

            return list;
        }

        [HttpPost]
        public RezervacijeVM Insert(RezervacijeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
