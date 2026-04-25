namespace Task3
{
    public class OrderLimitExceededException : Exception
    {
        public OrderLimitExceededException() : base() { }

        public OrderLimitExceededException(string message) : base(message) { }

        public OrderLimitExceededException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}