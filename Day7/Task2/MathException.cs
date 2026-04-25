namespace Task2
{
    public class MathException : Exception
    {
        public MathException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}