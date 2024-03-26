using CoffeeShop.Coffees;
using CoffeeShop.Interfaces;
using CoffeeShop.Milks;
using System.Buffers;
using System.Text;

namespace CoffeeShop
{
    public class CoffeeMaker : ICoffeeMaker
    {
        private List<ICoffee> _coffees;
        public CoffeeMaker()
        {
            _coffees = new List<ICoffee>();
        }
        public void AddMoreMilk(ICoffee coffee, IMilk milk)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            if (!isValidMilk(milk))
            {
                throw new ArgumentException("Invalid milk name!");
            }

            coffee.Milk.Add(milk);  
        }

        public void AddMoreSugar(ICoffee coffee, int countSugar)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            coffee.Sugar += countSugar;
        }

        public void MakeCoffee(ICoffee coffee)
        {
            if (!isValidCoffee(coffee))
            {
                throw new ArgumentException("Invalid coffee name!");
            }

            _coffees.Add(coffee);

        }

        public string OrderInfo(ICoffee coffee)
        {
            var sb = new StringBuilder();

            sb.Append("Coffee: ");
            sb.Append("Black Coffee");

            if (coffee.Milk.Any())
            {
                sb.Append(" with ");
                foreach (var milk in coffee.Milk)
                {
                    sb.Append($"+ {milk.GetType().Name} ");
                }
            }

            if (coffee.Sugar > 0)
            {
                string sugarString = coffee.Sugar == 1 ? " sugar." : " sugars.";
                sb.Append($" and {coffee.Sugar}{sugarString}");
            }

            return sb.ToString();
        }

        private bool isValidCoffee(ICoffee coffee)
        {
            var coffeeName = coffee.GetType().Name;

            if (coffeeName != nameof(Cappuccino) && coffeeName != nameof(FlatWhite) && coffeeName != nameof(Espresso))
            {
                return false;
            }

            return true;
        }

        private bool isValidMilk(IMilk milk)
        {
            var milkName = milk.GetType().Name;

            if (milkName != nameof(SoyMilk) && milkName != nameof(RegularMilk) && milkName != nameof(OatMilk))
            {
                return false;
            }

            return true;
        }
    }

}
