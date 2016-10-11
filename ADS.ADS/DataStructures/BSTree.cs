using ADS.ADS.Data;

namespace ADS.ADS.DataStructures
{
    public class BSTree
    {
        private Node _root;

        public bool Add(IData data)
        {
            if (_root!=null)
            {
            _root = new Node(data);
            return true;
            }

            return _root.Add(data);
        }
}
