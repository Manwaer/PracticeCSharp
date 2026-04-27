namespace Task2
{
    public class SortedListManager<TKey, TValue> where TKey : IComparable<TKey>
    {
        private MySortedList<TKey, TValue> _list = new MySortedList<TKey, TValue>();

        public void AddItem(TKey key, TValue value)
        {
            _list.Add(key, value);
        }

        public void RemoveItem(TKey key)
        {
            if (_list.Remove(key)) Console.WriteLine($"Элемент {key} удален.");
            else Console.WriteLine("Элемент не найден.");
        }

        public void SearchAndPrint(TKey key)
        {
            TValue result = _list.Find(key);
            if (result != null) Console.WriteLine($"Найдено: {result}");
            else Console.WriteLine("Ничего не найдено.");
        }

        public void DisplayList()
        {
            _list.PrintAll();
        }
    }
}