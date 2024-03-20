namespace Assignment.Interfaces
{
    internal interface ILogger
    {
        Task<string> LogAsync(string method, string outcome);
    }
}
