using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Accepted.Models;
using AcceptedInterView.Data;
using Accepted.Queries;
using MediatR;
using Accepted.Commands;

namespace Accepted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {         
        private readonly IMediator _mediator;

        public MatchesController(IMediator mediator)
        {
            _mediator = mediator;           
        }      
      
        [HttpGet]
        public async Task<IActionResult> GetMatch()
        {
            var query = new GetAllMatchesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
       
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatch(int id)
        {
            var query = new GetMatchByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? (IActionResult)Ok(result) : NotFound();            
        }
       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatch(int id, Match match)
        {
            if (id != match.Id)
            {
                return BadRequest();
            }
            var query = new UpdateMatchCommands(match);
            var result = await _mediator.Send(query);
            return result == null ? (IActionResult)NoContent() : NotFound(); 
        }
       
        [HttpPost]
        public async Task<ActionResult<Match>> PostMatch(CreateMatchCommand match)
        {                                                                             
            var result = await _mediator.Send(match);                                  
            return CreatedAtAction("GetMatch", new { id = result.Id }, result);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Match>> DeleteMatch(int id)
        {
            var query = new DeleteMatchCommand(id); 
            var result= await _mediator.Send(query);

            return result;


        }
       
    }
}
