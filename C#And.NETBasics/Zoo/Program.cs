using System.Diagnostics.Contracts;
using Zoo.Animals;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Lion lion = new Lion("Sim", 14);
            Bear bear = new Bear("Pooh", 5);
            Monkey monkey = new Monkey("Coco", 3);
            Turtle turtle = new Turtle("Franklin", 8);

            zoo.AddAnimals(lion);
            zoo.AddAnimals(bear);
            zoo.AddAnimals(monkey);
            zoo.AddAnimals(turtle);

            foreach (var animal in zoo)
            {
                Console.WriteLine($"Animal's name is {animal.Name} and it's {animal.Age} years old!");
                animal.Eat();
            }


            //Copy of the zoo and assign it to clonedZoo
            Zoo clonedZoo = (Zoo) zoo.Clone();
            foreach (var animal in clonedZoo)
            {
                Console.WriteLine($"Animal's name is {animal.Name} and it's {animal.Age} years old!");
                animal.Eat();
            }
        }
    }
}
