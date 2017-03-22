using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.DataProvider.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Cache
{
    [DI(typeof(ITrainCache), Lifetime = Lifetime.Singleton)]
    internal class DefaultTrainCache : DefaultMemoryCache<Train>, ITrainCache
    {
        public DefaultTrainCache()
        {
            Init(items =>
            {
                // import train metadata
            });
        }
    }
}