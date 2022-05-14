#region

using System;
using System.Collections.Generic;

#endregion

namespace MemoryCache.Models
{
    public class TeamSquad
    {
        public List<Player> Players { get; set; }
        public DateTime CheckTime { get; set; }
    }
}
