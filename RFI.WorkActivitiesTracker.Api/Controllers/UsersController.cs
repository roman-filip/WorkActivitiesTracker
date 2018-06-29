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
