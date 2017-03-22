using System.Collections.Generic;

using RoutePlanning.Algorithm.TimeIndependent.Model;

namespace RoutePlanning.Algorithm.TimeIndependent
{
    public interface IDataProvider
    {
        IEnumerable<Edge> GetOutgoingEdges(Node node);
    }
}