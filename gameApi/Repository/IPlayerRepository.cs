using System;
using System.Collections.Generic;
using gameApi.Models;

namespace gameApi.Repository
{
    public interface IPlayerRepository : IRepository<Player>, IDisposable
    {
    }
}