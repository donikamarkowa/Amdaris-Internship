namespace OOPFundamentals
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!;
        public string Location { get; set; } = null!;
        public List<Workout> Workouts { get; set; }
    }
}
