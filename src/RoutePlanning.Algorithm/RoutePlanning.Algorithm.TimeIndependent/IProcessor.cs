using System.Collections.Generic;

using RoutePlanning.Algorithm.TimeIndependent.Model;

namespace RoutePlanning.Algorithm.TimeIndependent
{
    public interface IProcessor
    {
        List<Node> Run(Node source, Node target);
    }
}