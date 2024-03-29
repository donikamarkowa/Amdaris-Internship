namespace Assignment
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException()
        {
            
        }
        public NegativeAgeException(string message) : base(message)
        {

        }
        public NegativeAgeException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
