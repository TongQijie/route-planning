using RoutePlanning.Algorithm.TimeDependent.Model;

namespace RoutePlanning.Algorithm.TimeDependent
{
    public interface IPriorityQueue
    {
         void Enqueue(SettledNode settledNode);

         bool IsEmpty();

         SettledNode Dequeue();
    }
}