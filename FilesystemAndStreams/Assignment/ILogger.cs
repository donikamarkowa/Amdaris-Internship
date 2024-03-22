namespace Assignment
{
    internal interface ILogger
    {
        Task LogAsync(string method, bool outcome);
    }
}
