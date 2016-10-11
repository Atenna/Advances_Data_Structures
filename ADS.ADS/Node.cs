using ADS.ADS.Data;

namespace ADS.ADS
{
    public class Node
    {
        public IData Data;

        public Node(IData data)
        {
            this.Data = data;
        }

        public Node NodeLeft { get; private set; }
        public Node NodeRight { get; private set; }
        public Node NodeAncestor { get; private set; }

        public bool Add(IData data)
        {
            if (data.Compare(Data) == 0)
            {
                return false;
            }
            else if (data.Compare(Data) == -1)
            {
                if (NodeLeft == null)
                {
                    NodeLeft = new Node(data);
                    return true;
                }
                else
                {
                    return NodeLeft.Add(data);
                }
            }
            else
            {
                if (NodeRight == null)
                {
                    NodeRight = new Node(data);
                    return true;
                }
                else
                {
                    return NodeRight.Add(data);
                }
            }
        }
    }
}
