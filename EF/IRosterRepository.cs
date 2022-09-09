using Microsoft.AspNetCore.Mvc;

namespace Lab1Test.EF
{
    public interface IRosterRepository
    {
        public Task<IEnumerable<Roster>> GetPlayers();
    }
}
