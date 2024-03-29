namespace Zoo.Animals
{
    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("I'm eating animals!");
        }
    }
}
