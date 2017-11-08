using System;
using System.Collections.Generic;

namespace Kata.November2017
{
    public class ItemCounter<T>
    {
        private readonly Dictionary<T, int> _itemCounts = new Dictionary<T, int>();

        public int DistinctItems
        {
            get { return _itemCounts.Count; }
        }

        public int GetCount(T item)
        {
            if (HasItem(item))
            {
                return _itemCounts[item];
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool HasItem(T item)
        {
            return _itemCounts.ContainsKey(item);
        }


        public ItemCounter(T[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in items)
            {
                if (HasItem(item))
                {
                    _itemCounts[item]++;
                }
                else
                {
                    _itemCounts.Add(item, 1);
                }
            }
        }
    }
}
