namespace OOPFundamentals
{
    public class Rating
    {
        public int Id { get; set; }
        public string User { get; set; } = null!;
        public string WorkoutRaiting { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
