namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(string make, string model, int year, int seatsCount, decimal price) : base(make, model, year, seatsCount, price)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving car {this.Make} {this.Model}.");
        }
    }
}
