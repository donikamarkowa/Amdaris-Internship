#define CUSTOM
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowNegativeAgeException();

                string name = Console.ReadLine()!;
                int age = int.Parse(Console.ReadLine()!);

                AddPerson(name, age);
            }
            catch (NegativeAgeException ne)
            {
                Console.WriteLine($"NegativeAgeException: {ne.Message}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Argument Exception caught and rethrown");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An expected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed!");
            }
        }

        static void AddPerson(string name, int age)
        {
#if CUSTOM
            if (age < 0)
            {
                throw new NegativeAgeException("Age cannot be negative!");
            }
#endif  
            List<Person> persons = new List<Person>();
            Person person = new Person()
            {
                Name = name,
                Age = age
            };

            persons.Add(person);
            Console.WriteLine($"Add person {person.Name} to list.");

        }

        static void ThrowNegativeAgeException()
        {
#if DEBUG               
            throw new NegativeAgeException("NegativeAgeException thrown.");
#else
            throw new Exception("Normal exception thrown");
#endif
        }

    }
}
