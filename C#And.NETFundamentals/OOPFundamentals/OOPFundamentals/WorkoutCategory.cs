using OOPFundamentals;

namespace OOPFundamentalsDiagram
{
    public class WorkoutCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Workout> Workouts { get; set; } = null!;
    }
}
