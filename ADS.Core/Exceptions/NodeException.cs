using System;

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
