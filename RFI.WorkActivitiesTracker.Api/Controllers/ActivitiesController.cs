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
    [Route("api/Activities")]
    public class ActivitiesController : Controller
    {
        // GET: api/Activities
        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return new List<Activity>
            {
                new Activity { Id = 1, Name = "Development" },
                new Activity { Id = 2, Name = "Meeting" },
                new Activity { Id = 3, Name = "Testing" }
            };
        }

        // GET: api/Activities/5
        [HttpGet("{id}")]
        public Activity Get(int id)
        {
            return new Activity { Id = id, Name = "Development" };
        }

        // GET: api/Activities/5/WorkActivities
        [HttpGet("{idActivity}/WorkActivities")]
        public IEnumerable<WorkActivity> GetWorkActivities(int idActivity)
        {
            return new List<WorkActivity>
            {
                new WorkActivity
                {
                    Id = idActivity,
                    StartTime = DateTime.Now.AddHours(-5),
                    EndTime = DateTime.Now,
                    User = new User { Id = 1, FirstName = "Roman", LastName = "FILIP" },
                    Project = new Project { Id = 1, Name = "CS44" },
                    Activity = new Activity { Id = 1, Name = "Development" }  // makes no sense in this controller
                }
            };
        }

        // POST: api/Activities
        [HttpPost]
        public void Post([FromBody]Activity activity)
        {
        }

        // PUT: api/Activities/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Activity activity)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
