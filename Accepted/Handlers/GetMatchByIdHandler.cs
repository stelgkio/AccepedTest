using Accepted.Models;
using Accepted.Queries;
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
    public class GetMatchByIdHandler : IRequestHandler<GetMatchByIdQuery, Match>
    {
        private readonly IMatchRepository _repo;

        public GetMatchByIdHandler(IMatchRepository repo)
        {
            _repo = repo;
        }
        public async Task<Match> Handle(GetMatchByIdQuery request, CancellationToken cancellationToken)
        {

            var match = await _repo.GetMatchById(request.Id);

            if (match == null) {
                return null;
            }

            return match;
        }
    }
}
