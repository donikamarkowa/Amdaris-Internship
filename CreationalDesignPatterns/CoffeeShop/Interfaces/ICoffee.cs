namespace CoffeeShop.Interfaces
{
    public interface ICoffee
    {
        public int BlackCoffee { get; set; }
        public int Sugar { get; set; }
        public List<IMilk> Milk { get; set; }
    }
}
