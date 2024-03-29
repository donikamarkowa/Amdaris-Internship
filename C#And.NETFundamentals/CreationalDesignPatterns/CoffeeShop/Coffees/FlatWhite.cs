using CoffeeShop.Interfaces;
using CoffeeShop.Milks;

namespace CoffeeShop.Coffees
{
    public class FlatWhite : ICoffee
    {
        public FlatWhite()
        {
            BlackCoffee = 2;
            Sugar = 0;
            Milk = new List<IMilk> { new RegularMilk()};
        }
        public int BlackCoffee { get ; set ; }
        public int Sugar { get ; set ; }
        public List<IMilk> Milk { get ; set ; }
    }
}
