using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eZeljeznice.Model;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace eZeljeznice.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class ZeljeznickeStaniceController : ControllerBase
    {
        private readonly IZeljeznickeStaniceService _service;
        public ZeljeznickeStaniceController(IZeljeznickeStaniceService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<ZeljeznickeStaniceVM> Get()
        {
            var list = _service.Get();

            return list;
        }

        [HttpGet("{id}")]
        public ZeljeznickeStaniceVM Get(int id)
        {
            return _service.GetById(id);
        }
    }
}