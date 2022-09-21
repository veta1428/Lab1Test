using Lab1Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1Test.EF
{
    public interface IRosterRepository
    {
        public Task<IEnumerable<Roster>> GetPlayers();

        public Task<IEnumerable<Roster>> GetPlayersByPosition(Position position);

        public Task<IEnumerable<Roster>> GetPlayersByYearOfBirth(int? from, int? to);

        public Task<IEnumerable<Roster>> GetFilteredPlayersAsync(FilterQuery filter);

        public Task Update(string playerId, DateTime birthday, string city, string country);

        public Task<Roster> GetById(string id);
    }
}
