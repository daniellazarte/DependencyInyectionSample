using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Depednency.Project.Web.Example.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Depednency.Project.Web.Example.Controllers
{
    [Route("/")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly IScopedOperation _scopedoperation;
        private readonly ItransientOperation _transientoperation;
        // GET: api/<DemoController>

        public DemoController(ISingletonOperation singletonoperation,IScopedOperation scopedoperation,ItransientOperation transientoperation)
        {
            _singletonOperation = singletonoperation;
            _scopedoperation = scopedoperation;
            _transientoperation = transientoperation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var resultSingleton =  _singletonOperation.Id;
            var resultScoped = _scopedoperation;
            var resulttransient = _transientoperation;
            
            return Ok(resultSingleton);
            //return Ok(resultScoped);
            //return Ok(resulttransient);
        }
    }
}
