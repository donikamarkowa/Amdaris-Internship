namespace OOPFundamentals
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Schedule { get; set; } = null!;
        public int MaxCapacity { get; set; }
        public string Trainer { get; set; } = null!;

    }
}
