#region

using MemoryCache.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using MemoryCache.Services;
using System.Collections.Generic;

#endregion

namespace MemoryCache.Services
{
    public class MemoryCacheService : IMemoryCacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ITeamService _teamService;

        public MemoryCacheService(IMemoryCache memoryCache, ITeamService teamService)
        {
            _memoryCache = memoryCache;
            _teamService = teamService;
        }

        public TeamSquad GetTeamSquad()
        {
            var cacheKey = "teamSquad";
            if(_memoryCache.TryGetValue(cacheKey, out TeamSquad teamSquad))
            {
                return teamSquad;
            }
            else
            {
                var players = _teamService.GetPlayers();
                var teamSquadPlayers = new TeamSquad
                {
                    CheckTime = DateTime.Now,
                    Players = players
                };
                _memoryCache.Set(cacheKey, teamSquadPlayers, TimeSpan.FromMinutes(1));

                return teamSquadPlayers;
            }

        }
    }
}
