using System.Collections;
using Zoo.Animals;

namespace Zoo
{
    public class Zoo : IEnumerable<Animal>, ICloneable
    {
        public List<Animal> animals = new List<Animal> ();  

        public void AddAnimals(Animal animal)
        {
            animals.Add(animal);   
        }

        public object Clone()
        {
            var clonedZoo = new Zoo();
            foreach (var animal in animals)
            {
                clonedZoo.animals.Add(animal);  
            }

            return clonedZoo;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return animals.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator ();    
        }
    }
}
