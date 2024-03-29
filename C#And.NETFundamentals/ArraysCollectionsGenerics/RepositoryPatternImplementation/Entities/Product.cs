namespace RepositoryPatternImplementation.Entities
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
