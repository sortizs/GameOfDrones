using GameDronesServices.Models;
using GameDronesServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameDronesServices.Controllers
{
    public class PlayerController : ApiController
    {
        IRepositoryBase<Player> _repository;

        public PlayerController(IRepositoryBase<Player> repository)
        {
            _repository = repository;
        }

        // GET: api/player
        public IEnumerable<Player> Get()
        {
            return _repository.GetAll();
        }

        // POST: api/player
        public IHttpActionResult Post(Player player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Create(player);
            return CreatedAtRoute("DefaultApi", new { id = player.Id }, player);
        }
    }
}
