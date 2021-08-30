using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Accepted.Models;
using AcceptedInterView.Data;

namespace Accepted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchOddsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MatchOddsController(ApplicationDbContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatchOdds>>> GetMatchOdds()
        {
            return await _context.MatchOdds.ToListAsync();
        }

     
        [HttpGet("{id}")]
        public async Task<ActionResult<MatchOdds>> GetMatchOdds(int id)
        {
            var matchOdds = await _context.MatchOdds.FindAsync(id);

            if (matchOdds == null)
            {
                return NotFound();
            }

            return matchOdds;
        }

     
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatchOdds(int id, MatchOdds matchOdds)
        {
            if (id != matchOdds.Id)
            {
                return BadRequest();
            }

            _context.Entry(matchOdds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchOddsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<MatchOdds>> PostMatchOdds(MatchOdds matchOdds)
        {
            _context.MatchOdds.Add(matchOdds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMatchOdds", new { id = matchOdds.Id }, matchOdds);
        }

        // DELETE: api/MatchOdds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MatchOdds>> DeleteMatchOdds(int id)
        {
            var matchOdds = await _context.MatchOdds.FindAsync(id);
            if (matchOdds == null)
            {
                return NotFound();
            }

            _context.MatchOdds.Remove(matchOdds);
            await _context.SaveChangesAsync();

            return matchOdds;
        }

        private bool MatchOddsExists(int id)
        {
            return _context.MatchOdds.Any(e => e.Id == id);
        }
    }
}
