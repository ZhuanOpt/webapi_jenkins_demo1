using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Jenkins_demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssff");
        }


        [HttpGet("{id}")]
        public string Get(string id)
        {
            return $"{id}:-> {DateTime.Now:yyyyMMddHHmmssff}";
        }
    }
}
