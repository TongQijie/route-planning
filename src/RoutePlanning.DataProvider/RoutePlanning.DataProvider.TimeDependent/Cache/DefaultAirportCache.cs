using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.DataProvider.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Cache
{
    [DI(typeof(IAirportCache), Lifetime = Lifetime.Singleton)]
    internal class DefaultAirportCache : DefaultMemoryCache<Airport>, IAirportCache
    {
        public DefaultAirportCache()
        {
            Init(items =>
            {
                // import airport metadata
            });
        }
    }
}