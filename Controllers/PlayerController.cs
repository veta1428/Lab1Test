using Lab1Test.EF;
using Lab1Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1Test.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IRosterRepository _rosterRepository;

        public PlayerController(IRosterRepository rosterRepository)
        {
            _rosterRepository = rosterRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _rosterRepository.GetPlayers();
            return View(new PlayersViewModel() { Players = players });
        }

        [HttpGet]
        [Route("[controller]/[action]/{position}")]
        public async Task<IActionResult> GetPlayersByPosition(Position position)
        {
            var players = await _rosterRepository.GetPlayersByPosition(position);
            return View("GetPlayers", new PlayersViewModel() { Players = players, Position = position });
        }

        [HttpGet]
        [Route("[controller]/[action]/{from}/{to}")]
        public async Task<IActionResult> GetPlayersByYearOfBirth(int? from, int? to)
        {
            var players = await _rosterRepository.GetPlayersByYearOfBirth(from, to);
            return View("GetPlayers", new PlayersViewModel() { Players = players, From = from, To = to });
        }

        [HttpPost]
        public async Task<IActionResult> EditPlayer(EditPlayerModel model)
        {
            await _rosterRepository.Update(model.PlayerId, model.Birthday, model.Birthcity, model.Birthstate);
            var players = await _rosterRepository.GetFilteredPlayersAsync(new FilterQuery() { From = model.From, To = model.To, Position = model.Position });
            return View("GetPlayers", new PlayersViewModel() { Players = players, Position = model.Position, To = model.To, From = model.From });
        }

        [HttpGet]
        public async Task<IActionResult> GetFilteredPlayers(PlayersViewModel model)
        {
            var players = await _rosterRepository.GetFilteredPlayersAsync(new FilterQuery() { From = model.From, To = model.To, Position = model.Position }) ;
            return View("GetPlayers", new PlayersViewModel() { Players = players, From = model.From, To = model.To, Position = model.Position });
        }
    }
}
