using Assignment.Interfaces;
using System.Text;

namespace Assignment
{
    internal class Logger : ILogger
    {
        private readonly string _logDirectory;
        public Logger(string logDirectory)
        {
            this._logDirectory = logDirectory;
        }
        public async Task<string> LogAsync(string method, string outcome)
        {
            try
            {
                Directory.CreateDirectory(_logDirectory);

                string logFileName = $"Logs_{DateTime.Now:dd-MM-yyyy HH-mm}.txt";
                string logFilePath = Path.Combine(_logDirectory, logFileName);
                string logMessage = $"{DateTime.Now:dd-MM-yyyy HH-mm}, Method: {method}, Outcome: {outcome}";

                using (StreamWriter streamWriter = new StreamWriter(logFilePath, true))
                {
                    await streamWriter.WriteLineAsync(logMessage);
                    return "Log written successfully!";
                }
            }
            catch (Exception ex)
            {
                return $"Error writing to log file: {ex.Message}";
            }

        }
    }
}
