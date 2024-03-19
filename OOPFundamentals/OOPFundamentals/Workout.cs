namespace OOPFundamentals
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string WorkoutCategory { get; set; } = null!;
        public string IntensityLevel { get; set; } = null!;
        public string EqupmentNeeded { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime Duration { get; set; }
        public int MaxCapacity { get; set; }
        public string Schedule { get; set; }
        public string Trainer { get; set; }
        public decimal Price { get; set; }
        public string RecommendedFrequency { get; set; } = null!;
        public double Rating { get; set; }
        public int NumberOfRatings { get; set; }
    }
}
