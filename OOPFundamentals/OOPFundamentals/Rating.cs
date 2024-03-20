using OOPFundamentals;

namespace OOPFundamentalsDiagram
{
    public class Rating
    {
        public int Id { get; set; }
        public User User { get; set; } = null!;
        public Rating Raiting { get; set; } = null!;
        public DateTime Date { get; set; }
        public Workout Workout { get; set; } = null!;
    }
}
