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
        public async Task<IEnumerable<Roster>> GetPlayersByPosition(string position)
        {
            return await _context.Rosters
                .Where(pl => pl.Position == position)
                .ToArrayAsync();
        }
    }
}
