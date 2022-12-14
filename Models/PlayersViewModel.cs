using Lab1Test.EF;
using System.ComponentModel.DataAnnotations;

namespace Lab1Test.Models
{
    public class PlayersViewModel
    {
        public IEnumerable<Roster> Players { get; set; } = null!;

        public Position? Position { get; set; } = null;

        public int? From { get; set; } = null;

        public int? To { get; set; } = null;
    }
}
