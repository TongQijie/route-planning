using System.Linq;
using System.Collections.Generic;

using Guru.DependencyInjection;
using Guru.DependencyInjection.Abstractions;

using RoutePlanning.Algorithm.TimeIndependent.Model;

namespace RoutePlanning.Algorithm.TimeIndependent
{
    [DI(typeof(IPriorityQueue), Lifetime = Lifetime.Singleton)]
    internal class DefaultPriorityQueue : IPriorityQueue
    {
        private List<SettledNode> _SettledNodes = new List<SettledNode>();

        public SettledNode Dequeue()
        {
            if (IsEmpty())
            {
                return null;
            }

            var n = _SettledNodes.OrderByDescending(x => x.Priority).First();
            _SettledNodes.Remove(n);
            return n;
        }

        public void Enqueue(SettledNode settledNode)
        {
            _SettledNodes.Add(settledNode);
        }

        public bool IsEmpty()
        {
            return _SettledNodes.Count == 0;
        }
    }
}