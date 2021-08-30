using Accepted.Models;
using AcceptedInterView.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Services
{
    public class MatchOddRepository : IMatchOddRepository
    {
        private readonly ApplicationDbContext _db;


        public MatchOddRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<List<MatchOdd>> GetAllMatchOdds()
        {
            throw new NotImplementedException();
        }

        public Task<MatchOdd> GetMatchOddById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMatchOdds(MatchOdd data)
        {
            throw new NotImplementedException();
        }
    }
}
