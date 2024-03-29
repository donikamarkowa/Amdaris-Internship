namespace Assignment
{
    internal class Person
    {
        private readonly ILogger _logger;
        public Person(string name, int age, string phoneNumber, ILogger logger)
        {
            this.Name = name;
            this.Age = age; 
            this.PhoneNumber = phoneNumber;
            _logger = logger;
        }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public async Task ChangePhoneNumber(string newPhoneNumber)
        {
            try
            {
                await _logger.LogAsync(nameof(ChangePhoneNumber), true);
                this.PhoneNumber = newPhoneNumber;
            }
            catch (Exception)
            {
                await _logger.LogAsync(nameof(ChangePhoneNumber), false);
                throw;
            }
               
        }
    }
}
