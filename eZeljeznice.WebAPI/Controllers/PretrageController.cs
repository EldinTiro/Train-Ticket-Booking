using eZeljeznice.Model;
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
    public class PretrageController : ControllerBase
    {
        private readonly IPretrageService _service;

        public PretrageController(IPretrageService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<PretragaVM> Get()
        {
            var list = _service.Get();

            return list;
        }
    }
}
