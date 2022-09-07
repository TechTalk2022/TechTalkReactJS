﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechTalkReactJSAPI.Controllers
{
     
    public class ValuesController : ControllerBase
    {
        // GET api/values
         
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
       
        public void Delete(int id)
        {
        }
    }
}
