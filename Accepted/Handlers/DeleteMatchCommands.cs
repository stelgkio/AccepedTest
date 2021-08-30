using Accepted.Commands;
using Accepted.Models;
using Accepted.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Accepted.Handlers
{
    public class DeleteMatchCommands : IRequestHandler<DeleteMatchCommand, Match>
    {
        private readonly IMatchRepository _repo;

        public DeleteMatchCommands(IMatchRepository repo)
        {
            _repo = repo;
        }
        public async Task<Match> Handle(DeleteMatchCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteMatch(request.Id);
        }
    }
}
