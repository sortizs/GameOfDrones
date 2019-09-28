using System;
using System.Collections.Generic;
using gameApi.Models;

namespace gameApi.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private GameDronesContext context = new GameDronesContext();

        public IEnumerable<Player> GetAll(){
            return context.Player;
        }

        public void Save(Player player){
            context.Player.Add(player);
            context.SaveChanges();
        }

        protected void Dispose(bool disposing) {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose(){
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}