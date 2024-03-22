namespace Assignment.Interfaces
{
    internal interface ILogger
    {
        Task LogAsync(string method, bool outcome);
    }
}
