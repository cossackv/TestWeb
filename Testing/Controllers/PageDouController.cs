using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageDouController : ControllerBase
    {
        
        [HttpGet]
        public Task<string> Get()
        { 
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Get", "C# Web API");

            var content = client.GetStringAsync("https://dou.ua/");
            
            return content;
        }
    }
}
