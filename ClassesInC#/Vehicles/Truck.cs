namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(string make, string model, int year, int seatsCount, decimal price) : base(make, model, year, seatsCount, price)
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"Driving truck {this.Make} {this.Model}.");
        }
    }
}
