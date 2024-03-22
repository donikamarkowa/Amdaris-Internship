namespace Assignment
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string logDirectory = $"{Environment.CurrentDirectory}";
            var logger = new Logger(logDirectory);

            Person person = new Person("Test", 34, "0897654435", logger);
            try
            {
                string newPhoneNumber = "0893876657";
                await person.ChangePhoneNumber(newPhoneNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
;
        }
    }
}
