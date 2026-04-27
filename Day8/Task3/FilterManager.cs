namespace Task3
{
    public class FilterManager<T>
    {
        private readonly IFilter<T> _filter;

        public FilterManager(IFilter<T> filter)
        {
            _filter = filter;
        }

        public void PrintFiltered(IEnumerable<T> items, Func<T, bool> predicate)
        {
            var filteredItems = _filter.Filter(items, predicate);
            
            Console.WriteLine("Отфильтрованные элементы:");
            foreach (var item in filteredItems)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}