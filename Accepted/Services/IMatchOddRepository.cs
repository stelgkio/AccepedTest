using Accepted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Services
{
    public interface IMatchOddRepository
    {
        Task<MatchOdds> GetMatchOddById(string Id);

        Task<List<MatchOdds>> GetAllMatchOdds();

        Task<bool> UpdateMatchOdds(MatchOdds data);

    }
}
