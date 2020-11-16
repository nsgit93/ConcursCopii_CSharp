using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Services
{
    [Serializable]
    public class ServiceException: ApplicationException
    {
        public ServiceException()
        {
        }

        public ServiceException(String message): base(message)
        {
        }

        public ServiceException(String message, Exception cause): base(message, cause)
        {
        }

        public ServiceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
