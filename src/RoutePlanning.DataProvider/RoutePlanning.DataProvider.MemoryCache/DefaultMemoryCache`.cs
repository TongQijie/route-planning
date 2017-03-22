using System;
using System.Linq;
using System.Collections.Generic;

namespace RoutePlanning.DataProvider.MemoryCache
{
    public class DefaultMemoryCache<T> : IMemoryCache<T> where T : IUniqueItem
    {
        private List<T> _Items = new List<T>();

        public void Init(Action<List<T>> import)
        {
            import.Invoke(_Items);
        }

        public IEnumerable<T> All()
        {
            foreach (var item in _Items)
            {
                yield return item;
            }
        }

        public IEnumerable<T> Many(Predicate<T> predicate)
        {
            foreach (var item in _Items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public T Single(string id)
        {
            return _Items.FirstOrDefault(x => x.Id == id);
        }

        public T Single(Predicate<T> predicate)
        {
            return _Items.FirstOrDefault(x => predicate(x));
        }
    }
}