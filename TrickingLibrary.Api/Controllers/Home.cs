using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world!";
        }
    }
}
