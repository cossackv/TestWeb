using System;
using System.Collections.Generic;
using System.Linq;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private ILoggerManager _loggerManager;

        public DataController(ILoggerManager logger)
        {
            _loggerManager = logger;
        }

        Data firstData = new Data();

        [HttpGet]
        public Data Get()
        {
            return firstData;
        }
    }


}