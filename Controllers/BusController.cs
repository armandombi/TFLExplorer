using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace TFLExplorer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        // GET: api/Bus
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
    }
}
