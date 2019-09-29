using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameDronesServices.Models;

namespace GameDronesServices.Repositories
{
    public class PlayerRepository : IRepositoryBase<Player>, IDisposable
    {
        private DataContext context = new DataContext();

        public IEnumerable<Player> GetAll()
        {
            return context.Player;
        }

        public void Create(Player player)
        {
            var players = context.Player.Where(x => x.Username == player.Username).FirstOrDefault();
            if (players == null)
            {
                context.Player.Add(player);
                context.SaveChanges();
            }
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}