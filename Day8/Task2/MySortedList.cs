namespace Task2
{
    public class MySortedList<TKey, TValue> where TKey : IComparable<TKey>
    {
        private TKey[] _keys;
        private TValue[] _values;
        private int _count;

        public int Count => _count;

        public MySortedList()
        {
            _keys = new TKey[4];
            _values = new TValue[4];
            _count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            int index = Array.BinarySearch(_keys, 0, _count, key);
            if (index >= 0) throw new ArgumentException("Ключ уже существует");

            int insertIndex = ~index;

            if (_count == _keys.Length) Resize();

            for (int i = _count; i > insertIndex; i--)
            {
                _keys[i] = _keys[i - 1];
                _values[i] = _values[i - 1];
            }

            _keys[insertIndex] = key;
            _values[insertIndex] = value;
            _count++;
        }

        public bool Remove(TKey key)
        {
            int index = Array.BinarySearch(_keys, 0, _count, key);
            if (index < 0) return false;

            for (int i = index; i < _count - 1; i++)
            {
                _keys[i] = _keys[i + 1];
                _values[i] = _values[i + 1];
            }

            _count--;
            _keys[_count] = default;
            _values[_count] = default;
            return true;
        }

        public TValue Find(TKey key)
        {
            int index = Array.BinarySearch(_keys, 0, _count, key);
            if (index < 0) return default;
            return _values[index];
        }

        public void PrintAll()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"Ключ: {_keys[i]}, Значение: {_values[i]}");
            }
        }

        private void Resize()
        {
            int newCapacity = _keys.Length * 2;
            Array.Resize(ref _keys, newCapacity);
            Array.Resize(ref _values, newCapacity);
        }
    }
}
