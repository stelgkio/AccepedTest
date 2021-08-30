using Accepted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Services
{
    public interface IMatchRepository
    {

        Task AddMatch(Match data);
        Task<Match> GetMatchById(int Id);

        Task<List<Match>> GetAllMatchs();

        Task UpdateMatch(Match data);
    }
}
