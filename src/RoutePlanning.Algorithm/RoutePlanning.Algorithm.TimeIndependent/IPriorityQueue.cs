using RoutePlanning.Algorithm.TimeIndependent.Model;

namespace RoutePlanning.Algorithm.TimeIndependent
{
    public interface IPriorityQueue
    {
         void Enqueue(SettledNode settledNode);

         bool IsEmpty();

         SettledNode Dequeue();
    }
}