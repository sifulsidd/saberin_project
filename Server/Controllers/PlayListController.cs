using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_manager_start.Data.Models;
using music_manager_starter.Data;
using System;

namespace music_manager_starter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayListsController : ControllerBase
    {
        private readonly DataDbContext _context;

        public PlayListsController(DataDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayList>>> GetPlayLists()
        {
            return await _context.PlayLists.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<PlayList>> PostSong(PlayList playlist)
        {
            if (playlist == null)
            {
                return BadRequest("Play list cannot be null.");
            }


            _context.PlayLists.Add(playlist);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
