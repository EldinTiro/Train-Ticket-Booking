using eZeljeznice.Model;
using eZeljeznice.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Controllers
{
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommender _service;

        public RecommenderController(IRecommender service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetSlicnaPutovanja/{putovanjeID}")]
        public List<PutovanjaVM> GetSlicnaPutovanja(int putovanjeID)
        {
            return _service.GetSlicnaPutovanja(putovanjeID);
        }
    }
}
