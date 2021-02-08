using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eZeljeznice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusRezervacijeController : ControllerBase
    {
        private readonly IStatusRezervacijeService _service;

        public StatusRezervacijeController(IStatusRezervacijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<NekompletiraneRezervacijeResponse> Get()
        {
            var list = _service.Get();

            return list;
        }

        [HttpPut]
        public RezervacijeVM Update(RezervacijeVM request)
        {
            return _service.Update(request);
        }
    }
}