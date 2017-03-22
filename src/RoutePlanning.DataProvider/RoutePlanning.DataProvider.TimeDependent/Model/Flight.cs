using System;

using RoutePlanning.DataProvider.MemoryCache;
using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.DataProvider.TimeDependent.Model
{
    public class Flight : IEdge, IUniqueItem
    {
        public Flight(string id, INode from, INode to, TimeSpan duration)
        {
            Id = id;
            NF = from;
            NT = to;
            Duration = duration;
        }

        public string Id { get; private set; }

        public INode NF { get; private set; }

        public INode NT { get; private set; }

        public TimeSpan Duration { get; private set; }

        public DateTime DepartureTime { get; set; }
    }
}