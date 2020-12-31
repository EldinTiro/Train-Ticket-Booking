using eZeljeznice.Model;
using eZeljeznice.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "BasicAuthentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class KarteController : ControllerBase
    {
        private readonly IKarteService _service;

        [HttpPost]
        public KarteVM Insert(KartaInsertRequest request)
    }
}
