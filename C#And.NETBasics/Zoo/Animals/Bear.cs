namespace Zoo.Animals
{
    public class Bear : Animal
    {
        public Bear(string name, int age) : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("I'm eating honey!");
        }
    }
}
