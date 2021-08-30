using Accepted.Models;
using AcceptedInterView.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Services
{
    public class MatchRepository : IMatchRepository
    {
        private readonly ApplicationDbContext _db;


        public MatchRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddMatch(Match data)
        {
            try {
                _db.Match.Add(data);
                await _db.SaveChangesAsync();
            } catch (DbUpdateException ex) {

                throw new DbUpdateException(ex.Message);
            }
        }

        public async Task<List<Match>> GetAllMatchs()
        {
            var result = await _db.Match.ToListAsync();
            return result;
        }

        public async Task<Match> GetMatchById(int Id)
        {
            var result = await _db.Match.FindAsync(Id);
            return result;
        }

        public async Task UpdateMatch(Match data)
        {
            try {
                var result = await _db.Match.FindAsync(data.Id);

                result.UpdateData(data);
                await _db.SaveChangesAsync();
             

            } catch (DbUpdateException ex) {

                throw new DbUpdateException(ex.Message);
            }
        }
    }
}
