using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary_FootballPlayer;
using REST_ServiceFootballPlayer.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_ServiceFootballPlayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FBPlayerController : ControllerBase
    {
        private readonly IManagersFBP mgr = new ManagerFBP();
        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<PlayersController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer value)
        {
            return mgr.Create(value);
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer value)
        {
            return mgr.Update(id, value);
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
