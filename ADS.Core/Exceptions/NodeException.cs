using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Core.Exceptions
{
    public class NodeException : Exception
    {
        public NodeException(string message)
            : base(message)
        {
        }

        public static NodeException NodeValueAlreadyExistsException()
        {
            return new NodeException(Constants.Errors.NodeValueAlreadyExists);
        }
    } 
}
