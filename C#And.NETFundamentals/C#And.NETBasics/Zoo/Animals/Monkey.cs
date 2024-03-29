using System.Net.Mime;

namespace Zoo.Animals
{
    public class Monkey : Animal
    {
        public Monkey(string name, int age) : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("I'm eating bananas!");
        }
    }
}
