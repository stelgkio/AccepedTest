using Accepted.Commands;
using Accepted.Models;
using Accepted.Services;
using AcceptedInterView.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Accepted.Handlers
{
    public class CreateMatchHandler : IRequestHandler<CreateMatchCommand, Match>
    {
        private readonly IMatchRepository _repo;

        public CreateMatchHandler(IMatchRepository repo)
        {
            _repo = repo;
        }
        public async Task<Match> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            var data = new Match(request);
            await _repo.AddMatch(data);            
            return data;
        }
    }
}
