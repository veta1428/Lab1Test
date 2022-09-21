using Lab1Test.EF;

namespace Lab1Test.Models
{
    public class FilterQuery
    {
        public Position? Position { get; set; } = null;

        public int? From { get; set; } = null;

        public int? To { get; set; } = null;
    }
}
