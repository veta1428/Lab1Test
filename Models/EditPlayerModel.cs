using Lab1Test.EF;

namespace Lab1Test.Models
{
    public class EditPlayerModel
    {
        public string PlayerId { get; set; } = null!;

        public DateTime Birthday { get; set; }

        public string Birthcity { get; set; } = null!;

        public string Birthstate { get; set; } = null!;

        public Position? Position { get; set; } = null;

        public int? From { get; set; } = null;

        public int? To { get; set; } = null;
    }
}
