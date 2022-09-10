using Lab1Test.EF;

namespace Lab1Test.Models
{
    public class PlayersViewModel
    {
        public IEnumerable<Roster> Players { get; set; } = null!;

        public SortType SortType { get; set; } = SortType.None;

        public Position? Position { get; set; } = null;

        public int? From { get; set; } = null;

        public int? To { get; set; } = null;
    }
}
