﻿using Microsoft.AspNetCore.Mvc;

namespace Lab1Test.EF
{
    public interface IRosterRepository
    {
        public Task<IEnumerable<Roster>> GetPlayers();
        public Task<IEnumerable<Roster>> GetPlayersByPosition(string position);

        public Task<IEnumerable<Roster>> GetPlayersByYearOfBirth(int from, int to);
    }
}
