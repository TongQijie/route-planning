using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.DataProvider.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Cache
{
    [DI(typeof(IStationCache), Lifetime = Lifetime.Singleton)]
    internal class DefaultStationCache : DefaultMemoryCache<Station>, IStationCache
    {
        public DefaultStationCache()
        {
            Init(items =>
            {
                // import station metadata
            });
        }
    }
}