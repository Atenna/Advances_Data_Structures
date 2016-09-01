using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS
{
    public abstract class Node : INode
    {
        public Node NodeLeft { get; private set; }
        public Node NodeRight { get; private set; }
        public Node NodeAncestor { get; private set; }

    }
}
