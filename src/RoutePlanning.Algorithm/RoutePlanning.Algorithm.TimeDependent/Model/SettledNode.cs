using System;

namespace RoutePlanning.Algorithm.TimeDependent.Model
{
    public class SettledNode
    {
        public SettledNode(INode node, TimeSpan totalDuration, DateTime arrivalTime)
        {
            N = node;
            TotalDuration = totalDuration;
            ArrivalTime = arrivalTime;
        }

        public INode N { get; set; }

        public double Priority
        {
            get
            {
                return TotalDuration.TotalMinutes * -1;
            }
        }

        public TimeSpan TotalDuration { get; set; }

        public DateTime ArrivalTime { get; set; }

        public SettledNode Pre { get; set; }
    }
}