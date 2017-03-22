using System;
using System.Collections.Generic;

using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.Algorithm.TimeDependent
{
    public interface IProcessor
    {
         List<INode> Run(INode source, INode target, DateTime departureTime);
    }
}