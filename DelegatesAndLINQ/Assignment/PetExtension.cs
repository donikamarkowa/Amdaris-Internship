using System.Runtime.CompilerServices;

namespace Assignment
{
    public static class PetExtension
    {
        public static string Info(this Pet pet)
        {
            return $"Name: {pet.Name}, Age: {pet.Age}, Color: {pet.Color}.";
        }
    }
}
