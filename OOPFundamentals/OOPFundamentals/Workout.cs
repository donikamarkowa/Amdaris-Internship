namespace OOPFundamentals
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string IntensityLevel { get; set; } = null!;
        public string EqupmentNeeded { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Duration { get; set; }
        public string Trainer { get; set; } = null!;
        public string RecommendedFrequency { get; set; } = null!;
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public int NumberOfRatings { get; set; }
    }
}
