using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private int seatsCount;

        public string Make { get; set; }
        public string Model { get; set; } 
        public int Year { get; set; }
        public int SeatsCount
        {
            get
            {
                return seatsCount;  
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Number of seats must be positive!");
                }
                seatsCount = value;
            }
        }
        public decimal Price { get; set; }

        public Vehicle(string make, string model, int year, int seatsCount, decimal price)
        {
            this.Make = make;
            this.Model = model; 
            this.Year = year;
            this.SeatsCount = seatsCount;
            this.Price = price;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Driving {this.Make} {this.Model}.");
        }

        public virtual void PrintInfo(string make = null, int year = 0, decimal price = 0)
        {
            if (make == null)
            {
                Console.WriteLine($"The vehicle is from {year} year and costs {price}$.");
            }
            else if (year == 0)
            {
                Console.WriteLine($"{make} costs {price}$.");
            }
            else if (price == 0)
            {
                Console.WriteLine($"{make} is from {year}.");
            }
            else 
            {
                Console.WriteLine($"{make} is from {year} year and costs {price}$.");
            }
        }

        public virtual void ChangePrice(decimal amount = 0, string status = "increase")
        {
            if (status == "increase")
            {
                this.Price += amount;
            }
            else if (status == "discount")
            {
                this.Price -= amount;
            }
        }

    }
}
