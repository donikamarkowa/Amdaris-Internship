namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A4", 2007, 5, 10000);
            Truck iveco = new Truck("Iveco", "Stralis", 2021, 2, 55000);

            if (audi is Car)
            {
                Console.WriteLine("The vehicle is car.");
            }

            if (iveco is Truck)
            {
                Console.WriteLine("The vehicle is truck.");
            }

            audi.PrintInfo(year: audi.Year, price: audi.Price);
            iveco.PrintInfo(iveco.Make, audi.Year, audi.Price);

            Vehicle firstVehicle = audi as Vehicle;
            Vehicle secondVehicle = iveco as Vehicle;

            if (firstVehicle is not null)
            {
                firstVehicle.Drive();
            }

            if (secondVehicle is not null)
            {
                secondVehicle.Drive();
            }

        }

    }
}
