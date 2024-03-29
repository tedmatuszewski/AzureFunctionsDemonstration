﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test.Domain.Services;

namespace Test.API.Controllers
{
    public class ValuesController : BaseController
    {
        public ValuesController(ITestService service) : base(service)
        {
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var r = _service.SendAllWidgetEmails();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
