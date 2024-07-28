using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using medical_record_users_api.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace medical_record_users_api.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        public MedicalbdContext context;
        public UsersController(MedicalbdContext _context)
        {
            context = _context;
        }
        
     
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            Console.WriteLine(id);
            var user = await context.Users.FirstOrDefaultAsync<User>(x=>x.Id == id);

            if (user != null) {
                return user;
            }
            else {
                return NotFound("User doesn't find");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

