using Accepted.Models;
using Accepted.Queries;
using Accepted.Services;
using AcceptedInterView.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Accepted.Handlers
{
    public class GetAllMatchesHandler : IRequestHandler<GetAllMatchesQuery, List<Match>>
    {
        private readonly IMatchRepository _repo;

        public GetAllMatchesHandler(IMatchRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<Match>> Handle(GetAllMatchesQuery request, CancellationToken cancellationToken)
        {
           return await _repo.GetAllMatchs();
        }
    }
}
