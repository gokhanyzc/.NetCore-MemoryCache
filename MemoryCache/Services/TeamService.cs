#region

using System;
using System.Collections.Generic;
using MemoryCache.Models;

#endregion


namespace MemoryCache.Services
{
    public class TeamService : ITeamService
    {
        public TeamService()
        {

        }

        public List<Player> GetPlayers()
        {
            var players = new List<Player>{
                new Player
                {
                    Id = 1,
                    Name = "Muslera"
                },
                new Player
                {
                    Id = 2,
                    Name = "Kerem Aktürkoğlu"
                },
                new Player
                {
                    Id = 3,
                    Name = "Arda Turan"
                },
            };
            return players;
        }
    }
}
