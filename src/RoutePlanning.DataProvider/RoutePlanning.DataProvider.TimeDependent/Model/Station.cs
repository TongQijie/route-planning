using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Model
{
    public class Station : INode, IUniqueItem
    {
        public Station(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}