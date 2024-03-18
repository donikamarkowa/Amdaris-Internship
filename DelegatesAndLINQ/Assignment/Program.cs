namespace Assignment
{
    internal class Program
    {
        public delegate bool CompareDelegate(Pet pet);
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();

            Pet dog = new Pet()
            {
                Name = "Koko",
                Age = 2,
                Color = "Black"
            };
            Pet cat = new Pet()
            {
                Name = "Sis",
                Age = 4,
                Color = "White"
            };
            Pet turtle = new Pet()
            {
                Name = "Franklin",
                Age = 1,
                Color = "Green"
            };
            Pet rabbit = new Pet()
            {
                Name = "Ro",
                Age = 3,
                Color = "Black and white"
            };
            Pet mouse = new Pet()
            {
                Name = "Jerry",
                Age = 1,
                Color = "White"
            };

            pets.Add(dog);
            pets.Add(cat);
            pets.Add(turtle);
            pets.Add(rabbit);
            pets.Add(mouse);

            //Filter pets by color = white
            var whitePets = FilterPets(pets, p => p.Color.ToLower() == "white");
            Console.WriteLine("Filtered pets: ");
            DisplayPets(whitePets);

            //Use extension method
            Console.WriteLine($"Info about mouse: {mouse.Info()}");
            Console.WriteLine($"Info about dog: {dog.Info()}");

            Console.WriteLine();

            //Modify animals: Animals grow by one year
            Console.WriteLine("Modified pets:");
            ModifyPets(pets, p => p.Age++);
            DisplayPets(pets);

            Console.WriteLine();

            //Define the comparison delegate
            CompareDelegate isAgeEqualsToTwo = pet => pet.Age == 2;

            //Find the first pet matching the criteria
            Pet foundPet = Find(isAgeEqualsToTwo, pets);
            if (foundPet != null)
            {
                Console.WriteLine($"Found pet: {foundPet.Name}");
            }

            Console.WriteLine();

            //Using lambda expression
            var oldestPet = pets
                .Where(p => p.Age == pets.Max(pet => pet.Age))
                .Select(p => new { p.Name, p.Age })
                .FirstOrDefault();
            if (oldestPet != null)
            {
                Console.WriteLine($"The oldest pet is: {oldestPet.Name}. It is {oldestPet.Age} years old.");
            }

        }
        public static void DisplayPets(List<Pet> pets)
        {
            foreach (var p in pets)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }

        }

        /// <summary>
        /// Searche for a pet in the given list based on a specific criteria defined by compareDelegate
        /// </summary>
        /// <param name="compareDelegate"></param>
        /// <param name="pets"></param>
        /// <returns></returns>
        public static Pet Find(CompareDelegate compareDelegate, List<Pet> pets)
        {
            foreach (var pet in pets)
            {
                if (compareDelegate(pet))
                {
                    return pet;
                }
            }

            return null;
        }

        /// <summary>
        /// Filter a list of Pet obejcts based on a specified condition define by predicate function
        /// </summary>
        /// <param name="pets"></param>
        /// <param name="action"></param>
        public static List<Pet> FilterPets(List<Pet> pets, Func<Pet, bool> predicate)
        {
            List<Pet> filteredPets = new List<Pet>();
            foreach (var pet in pets)
            {
                if (predicate(pet))
                {
                    filteredPets.Add(pet);
                }
            }

            return filteredPets;
        }

        /// <summary>
        /// Apply specific action to each Pet object in the list
        /// </summary>
        /// <param name="pets"></param>
        /// <param name="action"></param>
        public static void ModifyPets(List<Pet> pets, Action<Pet> action)
        {
            foreach (var pet in pets)
            {
                action(pet);
            }
        }



    }
}
