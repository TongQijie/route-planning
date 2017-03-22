using System;

namespace RoutePlanning.Algorithm.TimeDependent.Model
{
    public interface IEdge
    {
        INode NF { get; }

        INode NT { get; }

        TimeSpan Duration { get; }

        DateTime DepartureTime { get; }
    }
}