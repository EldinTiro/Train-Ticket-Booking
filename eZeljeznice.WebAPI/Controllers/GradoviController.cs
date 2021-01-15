using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eZeljeznice.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Gradovi : ControllerBase
    {
        private readonly IGradoviService _service;
        public Gradovi(IGradoviService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<GradoviVM> Get()
        {
            var list = _service.Get();

            return list;
        }

        [HttpGet("{id}")]
        public GradoviVM Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public GradoviVM Insert(ObavjestenjeInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}