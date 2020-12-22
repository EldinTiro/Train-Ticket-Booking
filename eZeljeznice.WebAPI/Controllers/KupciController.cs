using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eZeljeznice.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;

        public KupciController(IKupciService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<KupciVM> Get([FromQuery]KupciSearchRequest request)
        {
            return _service.Get(request); ;
        }

        [HttpGet("{id}")]
        public KupciVM Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public KupciVM Insert(KupciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public KupciVM Update(int id, KupciInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}