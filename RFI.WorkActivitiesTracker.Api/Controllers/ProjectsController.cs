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
    [Route("api/Projects")]
    public class ProjectsController : Controller
    {
        // GET: api/Projects
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return new List<Project>
            {
                new Project { Id = 1, Name = "CS44" },
                new Project { Id = 2, Name = "CS45" },
                new Project { Id = 3, Name = "CS46" }
            };
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return new Project { Id = id, Name = "CS99" };
        }

        // POST: api/Projects
        [HttpPost]
        public void Post([FromBody]Project project)
        {
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Project project)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
