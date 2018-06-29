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
    [Route("api/Users")]
    public class UsersController : Controller
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User { Id = 1, FirstName = "Roman", LastName = "FILIP" },
                new User { Id = 2, FirstName = "Karel", LastName = "Novak" }
            };
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new User { Id = id, FirstName = "Roman", LastName = "FILIP" };
        }

        // GET: api/Users/5/WorkActivities
        [HttpGet("{idUser}/WorkActivities")]
        public IEnumerable<WorkActivity> GetWorkActivities(int idUser)
        {
            return new List<WorkActivity>
            {
                new WorkActivity
                {
                    Id = idUser,
                    StartTime = DateTime.Now.AddHours(-5),
                    EndTime = DateTime.Now,
                    User = new User { Id = 1, FirstName = "Roman", LastName = "FILIP" },  // makes no sense in this controller
                    Project = new Project { Id = 1, Name = "CS44" },
                    Activity = new Activity { Id = 1, Name = "Development" }
                }
            };
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
