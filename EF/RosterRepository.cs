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
        public async Task<IEnumerable<Roster>> GetPlayersByYearOfBirth(int from, int to)
        {
            return await _context.Rosters
                .Where(pl => pl.Birthday!.Value.Year >= from && pl.Birthday.Value.Year <= to)
                .ToArrayAsync();
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
    }
}
