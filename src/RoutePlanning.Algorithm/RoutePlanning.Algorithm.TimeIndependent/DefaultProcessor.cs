using System.Linq;
using System.Collections.Generic;

using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.Algorithm.TimeIndependent.Model;

namespace RoutePlanning.Algorithm.TimeIndependent
{
    [DI(typeof(IProcessor), Lifetime = Lifetime.Singleton)]
    internal class DefaultProcessor : IProcessor
    {
        private readonly IDataProvider _DataProvider;

        private readonly IPriorityQueue _PriorityQueue;

        public DefaultProcessor(IDataProvider dataProvider, IPriorityQueue priorityQueue)
        {
            _DataProvider = dataProvider;
            _PriorityQueue = priorityQueue;
        }

        private List<SettledNode> _SettledNodes = new List<SettledNode>();

        public List<Node> Run(Node source, Node target)
        {
            _PriorityQueue.Enqueue(new SettledNode(source, 0));

            while (!_PriorityQueue.IsEmpty())
            {
                var v = _PriorityQueue.Dequeue();

                if (v.N == target)
                {
                    var path = new List<Node>();
                    path.Add(v.N);
                    var n = v;
                    while (n.Pre != null)
                    {
                        path.Insert(0, n.Pre.N);
                        n = n.Pre;
                    }
                    return path;
                }

                foreach (var e in _DataProvider.GetOutgoingEdges(v.N))
                {
                    var w = e.NT;
                    if (!_SettledNodes.Exists(x => x.N == w))
                    {
                        var n = new SettledNode(w, v.Dist + e.Weight);
                        n.Pre = v;

                        _SettledNodes.Add(n);
                        _PriorityQueue.Enqueue(n);
                    }
                    else
                    {
                        var n = _SettledNodes.FirstOrDefault(x => x.N == w);
                        if (v.Dist + e.Weight < n.Dist)
                        {
                            n.Dist = v.Dist + e.Weight;
                            n.Pre = v;
                        }
                    }
                }
            }

            return null;
        }
    }
}