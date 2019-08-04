using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Domain.Services;

namespace Test.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ITestService _service;

        public BaseController(ITestService service)
        {
            this._service = service;
        }
    }
}