using GameDronesServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDronesServices.Repositories
{
    public class WinnerRepository : IRepositoryBase<Winner>, IDisposable
    {
        private DataContext context = new DataContext();

        public IEnumerable<Winner> GetAll()
        {
            return context.Winner;
        }

        public void Create(Winner winner)
        {
            context.Winner.Add(winner);
            context.SaveChanges();
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