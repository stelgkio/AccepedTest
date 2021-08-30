using Accepted.Commands;
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
    

        public async Task<List<Match>> GetAllMatchs()
        {
            try {
                var result = await _db.Match.ToListAsync();
                return result;
            } catch (Exception ex) {

                throw new Exception(ex.Message);
            }
          
        }

        public async Task<Match> GetMatchById(int Id)
        {
            try {
                var result = await _db.Match.FindAsync(Id);
                return result;
            } catch (Exception ex) {

                throw new Exception(ex.Message);
            }
          
        }

        public async Task UpdateMatch(UpdateMatchCommands data)
        {
            try {
                CheckSportValue(data.Sport);
                var result = await _db.Match.FindAsync(data.Id);

                result.UpdateData(data);
                await _db.SaveChangesAsync();
             

            } catch (DbUpdateException ex) {

                throw new DbUpdateException(ex.Message);
            }
        }
        public async Task AddMatch(Match data)
        {
            try {
                CheckSportValue(data.Sport);
                _db.Match.Add(data);
                await _db.SaveChangesAsync();
            } catch (DbUpdateException ex) {

                throw new DbUpdateException(ex.Message);
            }
        }
        public async Task<Match> DeleteMatch(int Id)
        {
            try {
                var match = await _db.Match.FindAsync(Id);
                if (match == null) {
                    return null;
                }

                match.IsDeleted = true;
                match.DeletedDate = DateTime.UtcNow;
                _db.Match.Update(match);
                await _db.SaveChangesAsync();

                return match;

            } catch (DbUpdateException ex) {

                throw new DbUpdateException(ex.Message);
            }
        }

        public void CheckSportValue(SportType sportType)
        {
            switch (sportType) {
                case SportType.FootBall:
                   
                case SportType.BasktBall:
                    
                default:
                    throw new Exception("Value of Sport is not correct");
                
            }

        }
    }
}
