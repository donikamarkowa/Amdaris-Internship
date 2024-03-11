namespace Zoo.Animals
{
    public abstract class Animal : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Eat();

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
