using Microsoft.AspNetCore.Mvc;
using ServerToAngular.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerToAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public List<User> Get()
        {
            return Data.users;
        }

       
        // POST api/<UsersController>
        [HttpPost]
        public int Post([FromBody] User user)
        {

            if (user.Id <= 0)
            {
                var max = Data.users.Max(x => x.Id);
                user.Id = max + 1;
            }
            Data.users.Add(user);
            return user.Id;
        }

       

    }
}
