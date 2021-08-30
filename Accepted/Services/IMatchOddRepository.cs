using Accepted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Services
{
    public interface IMatchOddRepository
    {
        Task<MatchOdd> GetMatchOddById(string Id);

        Task<List<MatchOdd>> GetAllMatchOdds();

        Task<bool> UpdateMatchOdds(MatchOdd data);

    }
}
