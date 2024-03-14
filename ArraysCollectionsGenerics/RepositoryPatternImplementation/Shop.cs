using RepositoryPatternImplementation.Entities;
using RepositoryPatternImplementation.Interfaces;

namespace RepositoryPatternImplementation
{
    public class Shop
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Customer> _customerRepository;

        public Shop(IRepository<Product> productRepository, IRepository<Customer> customerRepositor)
        {
            _productRepository = productRepository;
            _customerRepository = customerRepositor;    
        }

        public void BuyProduct(int customerId, int productId)
        {
           Customer customer = _customerRepository.GetById(customerId); 

            if (customer == null) 
            {
                Console.WriteLine($"Customer with {customer.Id} id does not exist!");
            }

            Product product = _productRepository.GetById(productId);    
            if (product == null)
            {
                Console.WriteLine($"Product with {product.Id} id does not exist!");
            }
            else
            {
                customer.Balance -= product.Price;
                _productRepository.Delete(product);

                Console.WriteLine($"Product {product.Name} was purchased by {customer.Name}. Their remaining balance: {customer.Balance}.");
            }

        }

        public void AddProduct(string name, decimal price, string category)
        {
            Product product = new Product()
            {
                Name = name,
                Price = price,
                Category = category
            };

            _productRepository.Add(product);    
        }
    }
}
