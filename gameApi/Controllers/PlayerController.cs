using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using gameApi.Models;
using gameApi.Repository;

namespace gameApi.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository playerRepository;

        public PlayerController(IPlayerRepository playerRepository){
            this.playerRepository = playerRepository;
        }

        // GET: api/Player
        public IEnumerable<Player> Get(){
            return playerRepository.GetAll();
        }

    }
}