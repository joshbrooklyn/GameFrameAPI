using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using GameFrameAPI.Entities;
using GameFrameAPI.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace GameFrameAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrentGameController : Controller
    {
        GamedleDBContext _context;
        IConfiguration _configuration;

        public CurrentGameController(GamedleDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [EnableCors("AllowLocalHost")]
        [HttpGet]
        public async Task<ActionResult<DailyGame>> Get()
        {
            DailyGame DailyGame = await _context.DailyGames
                .Include(dg => dg.Game)
                .OrderByDescending(dg => dg.GameDate)
                .FirstOrDefaultAsync();

            if (DailyGame is null || ((TimeSpan)(DateTime.Now - DailyGame.GameDate)).Days > 0)
            {
                List<Game> ValidGames = await _context.Games.ToListAsync();

                Random random = new Random();
                int start2 = random.Next(0, ValidGames.Count);

                DailyGame = new DailyGame()
                {
                    Game = ValidGames[start2],
                    GameDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                };

                await _context.DailyGames.AddAsync(DailyGame);
                await _context.SaveChangesAsync();
            }

            await _context.Entry<Game>(DailyGame.Game).Reference(g => g.Platform).LoadAsync();
            await _context.Entry<Game>(DailyGame.Game).Collection(g => g.Screenshots).LoadAsync();

            return DailyGame;
        }
    }
}
