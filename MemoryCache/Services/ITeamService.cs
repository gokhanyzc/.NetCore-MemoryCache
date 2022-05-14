#region

using System;
using System.Collections.Generic;
using MemoryCache.Models;

#endregion

namespace MemoryCache.Services
{
    public interface ITeamService
    {
        public List<Player> GetPlayers();

    }
}
