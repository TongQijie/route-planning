using System;
using System.Collections.Generic;

namespace RoutePlanning.DataProvider.MemoryCache
{
    public interface IMemoryCache<T> where T : IUniqueItem
    {
        void Init(Action<List<T>> import);

        IEnumerable<T> All();

        T Single(string id);

        T Single(Predicate<T> predicate);

        IEnumerable<T> Many(Predicate<T> predicate);
    }
}