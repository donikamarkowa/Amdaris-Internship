namespace Zoo.Animals
{
    public class Turtle : Animal
    {
        public Turtle(string name, int age) : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("I'm eating vegetables!");
        }
    }
}
