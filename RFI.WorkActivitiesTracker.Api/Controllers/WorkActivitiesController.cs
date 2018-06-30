using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RFI.WorkActivitiesTracker.Api.Models;

namespace RFI.WorkActivitiesTracker.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/WorkActivities")]
    public class WorkActivitiesController : Controller
    {
        // GET: api/WorkActivities
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/WorkActivities
        [HttpPost]
        public WorkActivity Post([FromBody]WorkActivity value)
        {
            // Create new WorkActivity == log start of work
            return value;
        }

        // PUT: api/WorkActivities/5
        [HttpPut("{id}")]
        public WorkActivity Put(int id, [FromBody]WorkActivity value)
        {
            // Update existing WorkActivity == log end of work
            return value;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
