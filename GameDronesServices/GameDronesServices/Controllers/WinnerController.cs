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
    public class WinnerController : ApiController
    {
        IRepositoryBase<Winner> _repository;

        public WinnerController(IRepositoryBase<Winner> repository)
        {
            _repository = repository;
        }

        // GET: api/winner
        public IEnumerable<Winner> Get()
        {
            return _repository.GetAll();
        }

        // POST: api/winner
        public IHttpActionResult Post(Winner winner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Create(winner);
            return CreatedAtRoute("DefaultApi", new { id = winner.Id }, winner);
        }
    }
}
