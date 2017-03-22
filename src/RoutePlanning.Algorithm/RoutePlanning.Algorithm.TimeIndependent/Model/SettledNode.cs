namespace RoutePlanning.Algorithm.TimeIndependent.Model
{
    public class SettledNode
    {
        public SettledNode(Node node, double dist)
        {
            N = node;
            Dist = dist;
        }

        public Node N { get; set; }

        public double Priority
        {
            get
            {
                return Dist * -1;
            }
        }

        public double Dist { get; set; }

        public SettledNode Pre { get; set; }

        public bool Settled { get; set; }
    }
}