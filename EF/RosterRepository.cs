using Lab1Test.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1Test.EF
{
    public class RosterRepository : IRosterRepository
    {
        private readonly Lab1Context _context;
        public RosterRepository(Lab1Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Roster>> GetPlayers()
        {
            return await _context.Rosters.ToArrayAsync();
        }
        public async Task<IEnumerable<Roster>> GetPlayersByPosition(Position position)
        {
            var query = _context.Rosters
                .Where(pl => pl.Position == position.ToString());

            return await query.ToArrayAsync();
        }
        public async Task<IEnumerable<Roster>> GetPlayersByYearOfBirth(int? from, int? to)
        {
            if (from == null && to == null)
            {
                return await GetPlayers();
            }
            else if (from == null)
            {
                return await _context.Rosters
               .Where(pl => pl.Birthday.Value.Year <= to)
               .ToArrayAsync();
            }
            else if (to == null)
            {
                return await _context.Rosters
               .Where(pl => pl.Birthday!.Value.Year >= from)
               .ToArrayAsync();
            } else
            {
                return await _context.Rosters
                .Where(pl => pl.Birthday!.Value.Year >= from && pl.Birthday.Value.Year <= to)
                .ToArrayAsync();
            }
            
        }

        // never do it again
        public async Task Update(string playerId, DateTime birthday, string city, string country)
        {
            var player = await GetById(playerId);

            player.Birthday = birthday;
            player.Birthstate = country;
            player.Birthcity = city;

            _context.Rosters.Update(player);

            await _context.SaveChangesAsync();
        }

        public async Task<Roster> GetById(string id)
        {
            return await _context.Rosters.FirstAsync(pl => pl.Playerid == id);
        }

        public async Task<IEnumerable<Roster>> GetFilteredPlayersAsync(FilterQuery filter)
        {
            return await _context.Rosters
                .Where(r => (filter.From == null) || (r.Birthday == null)  || (filter.From <= r.Birthday.Value.Year))
                .Where(r => (filter.To == null) || (r.Birthday == null) || (filter.To >= r.Birthday.Value.Year))
                .Where(r => (filter.Position == null) || (r.Position == null) || (filter.Position.ToString() == r.Position))
                .ToArrayAsync();
        }
    }
}
