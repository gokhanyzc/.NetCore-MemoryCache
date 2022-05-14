#region

using MemoryCache.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace MemoryCache.Controllers
{
    public class MemoryCacheController : Controller
    {

        private readonly IMemoryCacheService _memoryCacheService;

        public MemoryCacheController(IMemoryCacheService memoryCacheService)
        {
            _memoryCacheService = memoryCacheService;
        }

        public IActionResult Index()
        {
            var teamSquad = _memoryCacheService.GetTeamSquad();
            return View(teamSquad);
        }
    }
}
