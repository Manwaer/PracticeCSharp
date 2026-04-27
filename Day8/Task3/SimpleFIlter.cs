namespace Task3
{
    public class SimpleFilter<T> : IFilter<T>
    {
        public IEnumerable<T> Filter(IEnumerable<T> items, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}