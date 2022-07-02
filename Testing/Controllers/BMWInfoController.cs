using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BMWInfoController : ControllerBase
    {
        private string _carName;
        private string _carEngine;

        public BMWInfo GetInfo()
        {
            BMWInfo info = new BMWInfo();
            _carName = info.ModelName;
            _carEngine = info.EngineType;
            return info;
        }

        [HttpGet]
        public BMWInfo Get()
        {
            return GetInfo();
        }

    }

    
}
