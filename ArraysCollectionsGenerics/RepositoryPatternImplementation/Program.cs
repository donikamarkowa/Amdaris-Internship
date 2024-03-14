using RepositoryPatternImplementation.Entities;
using RepositoryPatternImplementation.Repositories;

namespace RepositoryPatternImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new Repository<Product>(new List<Product>());
            var customerRepository = new Repository<Customer>(new List<Customer>());

            var shop = new Shop(productRepository, customerRepository);

            shop.AddProduct("SmarthPhone", 1250.99m, "Electronics");
            shop.AddProduct("Dress", 32.99m, "Clothes");
            shop.AddProduct("Hair Dryer", 66.99m, "HealthAndBeauty");

            var customer1 = new Customer()
            {
                Id = 1,
                Name = "Peter",
                Balance = 1000
            };
            var customer2 = new Customer()
            {
                Id = 2,
                Name = "Andrey",
                Balance = 250
            };

            customerRepository.Add(customer1);

            shop.BuyProduct(customer1.Id, 1);
            
        }
    }
}
