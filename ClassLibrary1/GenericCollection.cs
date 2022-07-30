namespace ClassLibrary1
{
    public class GenericCollection<T>
    {
        private readonly int _maxSize;
        private int _currentIndex = -1;
        private readonly T[] _items;

        public GenericCollection(int maxSize = 5)
        {
            _maxSize = maxSize;
            _items = new T[maxSize];
        }
        public int Length { get { return _items.Length; } }

        public void GetFromIndex(int index)
        {
            if (index > _maxSize || index < 0)
            {
                throw new Exception($"Array does not have index: {index}");
            }
            Console.Write(_items[index]);
        }

        public void SetAtIndex(T item, int index)
        {
            if (index > _maxSize || index < 0)
            {
                throw new Exception($"Array does not have index: {index}");
            }
            _items[index] = item;
        }

        // Swapping by index
        public void SwapTwoItems(int firstIndex, int secondIndex)
        {
            if (firstIndex >= _items.Length || secondIndex >= _items.Length || firstIndex < 0 || secondIndex < 0)
            {
                throw new Exception("Index Out of Range.");
            }
            T tempItem = _items[firstIndex];
            _items[firstIndex] = _items[secondIndex];
            _items[secondIndex] = tempItem;
        }

        // Swapping by index - item combination
        public void SwapTwoItems(int firstIndex, T secondItem)
        {
            if (firstIndex < 0 || firstIndex >= _items.Length)
            {
                throw new Exception("Index out of range");
            }
            if (!_items.Contains(secondItem))
            {
                throw new Exception("Item does not exist in current collection");
            }
            T tempItem = _items[Array.IndexOf(_items, secondItem)];
            _items[Array.IndexOf(_items, secondItem)] = _items[firstIndex];
            _items[firstIndex] = tempItem;
        }

        // Swapping by items
        public void SwapTwoItems(T firstItem, T secondItem)
        {
            if(!_items.Contains(firstItem) || !_items.Contains(secondItem))
            {
                throw new Exception("The items do not exist in the current collection.");
            }
            else
            {
                int firstIndex = Array.IndexOf(_items, firstItem);
                int secondIndex = Array.IndexOf(_items, secondItem);

                T tempItem = _items[firstIndex];
                _items[firstIndex] = _items[secondIndex];
                _items[secondIndex] = tempItem;
            }
        }

        public void PrintCollection()
        {
            for(int i = 0; i < _items.Length; i++)
            {
                if (i == _maxSize - 1)
                {
                    Console.Write($"{_items[i]}.\n");
                }
                else
                {
                    Console.Write($"{_items[i]}, ");
                }
            }
        }
    }
}