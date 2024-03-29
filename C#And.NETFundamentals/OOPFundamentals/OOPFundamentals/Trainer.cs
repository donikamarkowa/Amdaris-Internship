using OOPFundamentalsDiagram;

namespace OOPFundamentals
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public Workout Workout { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public Rating Rating { get; set; } = null!;
    }
}
