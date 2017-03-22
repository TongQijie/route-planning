using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.DataProvider.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Cache
{
    [DI(typeof(IFlightCache), Lifetime = Lifetime.Singleton)]
    internal class DefaultFlightCache : DefaultMemoryCache<Flight>, IFlightCache
    {
        public DefaultFlightCache()
        {
            Init(items =>
            {
                // import flight metadata
            });
        }
    }
}