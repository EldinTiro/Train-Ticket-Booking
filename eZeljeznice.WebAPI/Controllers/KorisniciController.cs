using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.Model.Responses;
using eZeljeznice.WebAPI.Database;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eZeljeznice.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
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
        public List<KorisniciVM> Get([FromQuery]KorisniciSearchRequest request)
        {
            var list = _service.Get(request);

            return list;
        }
        [HttpGet("Loyalty")]
        public List<KorisniciLoyaltyResponse> GetLoyalty()
        {
            var list = _service.GetLoyalty();

            return list;
        }

        [HttpGet("{id}")]
        public KorisniciVM Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public KorisniciVM Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public KorisniciVM Update(int id, KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}