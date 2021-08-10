using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Maintainance.Controllers.Api
{
    public class InformationController : ApiController
    {
        // GET: api/Information
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Information/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Information
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Information/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Information/5
        public void Delete(int id)
        {
        }
    }
}
