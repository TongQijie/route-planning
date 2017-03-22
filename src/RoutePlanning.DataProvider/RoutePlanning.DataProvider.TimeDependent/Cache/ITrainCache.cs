using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.DataProvider.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Cache
{
    public interface ITrainCache : IMemoryCache<Train>
    {
    }
}