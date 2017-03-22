using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Model
{
    public class Airport : INode, IUniqueItem
    {
        public Airport(string id)
        {
            Id = id;
        }
        
        public string Id { get; set; }
    }
}