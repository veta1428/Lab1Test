using Lab1Test.EF;

namespace Lab1Test.Models
{
    public class PlayersViewModel
    {
        public IEnumerable<Roster> Players { get; set; } = null!;
    }
}
