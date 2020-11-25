using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Permission.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Welcome";
        }
    }
}
