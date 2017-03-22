using System;
using System.Collections.Generic;

using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.Algorithm.TimeDependent
{
    public interface IDataProvider
    {
         IEnumerable<IEdge> GetOutgoingEdges(INode node, DateTime arrivalTimeOfNode);
    }
}