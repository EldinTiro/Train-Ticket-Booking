using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace eZeljeznice.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PutovanjeController : ControllerBase
    {
        private readonly IPutovanjaService _service;
        public PutovanjeController(IPutovanjaService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<PutovanjaVM> Get([FromQuery]PutovanjaSearchRequest request)
        {
            var list = _service.Get(request);

            return list;
        }

        [HttpGet("TopRelations")]
        public List<RelacijeTopSearchResponse> GetTopRelations()
        {
            var list = _service.GetTopRelations();

            return list;
        }


        [HttpPost]
        public PutovanjaVM Insert(PutovanjaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public PutovanjaVM Update(int id, PutovanjaInsertRequest request)
        {
            return _service.Update(id, request);
        }
        [HttpPut]
        public List<string> UpdateAkcija(PutovanjaAkcijaRequest request)
        {
                return _service.UpdateAkcija(request);
        }

    }
    
}