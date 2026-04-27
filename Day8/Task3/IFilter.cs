namespace Task3
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Func<T, bool> predicate);
    }
}