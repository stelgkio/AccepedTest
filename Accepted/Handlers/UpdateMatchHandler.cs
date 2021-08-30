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
    public class UpdateMatchHandler : IRequestHandler<UpdateMatchCommands, Match>
    {
        private readonly IMatchRepository _repo;

        public UpdateMatchHandler(IMatchRepository repo)
        {
            _repo = repo;
        }

        public async Task<Match> Handle(UpdateMatchCommands request, CancellationToken cancellationToken)
        {
            await _repo.UpdateMatch(request);
            return null;
        }
    }
}
