namespace RepositoryPatternImplementation.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
