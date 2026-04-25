namespace Task1
{
    public class OverheatException : Exception
    {
        public OverheatException() : base() { }

        public OverheatException(string message) : base(message) { }

        public OverheatException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}