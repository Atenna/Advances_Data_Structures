using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.DataStructures
{
    public abstract class AbstractBinaryTree<TNode, TValue>
    {
        private TNode _root;

        public TNode Root
        {
            get { return _root; }
            protected set { _root = value; }
        }

        public void Clear()
        {
            _root = default(TNode);
        }

    }
}
