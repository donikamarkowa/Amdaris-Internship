namespace Assignment
{
    internal class Logger : ILogger
    {
        private readonly string _logDirectory;
        public Logger(string logDirectory)
        {
            _logDirectory = logDirectory;
        }
        public async Task LogAsync(string method, bool outcome)
        {
            try
            {
                Directory.CreateDirectory(_logDirectory);

                string logFileName = $"Logs_{DateTime.Now:dd-MM-yyyy HH-mm}.txt";
                string logFilePath = Path.Combine(_logDirectory, logFileName);
                string logMessage = $"{DateTime.Now:dd-MM-yyyy HH-mm}, Method: {method}, Outcome: {outcome}";

                if (!File.Exists(logFilePath))
                {
                    using (StreamWriter writer = File.CreateText(logFilePath))
                    {
                        await writer.WriteLineAsync($"Log file created on {DateTime.Now:dd-MM-yyyy HH-mm}");
                    }
                }

                using (StreamWriter streamWriter = new StreamWriter(logFilePath, true))
                {
                    await streamWriter.WriteLineAsync(logMessage);
                    Console.WriteLine("Log written successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }

        }
    }
}
