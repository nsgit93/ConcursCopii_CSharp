using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class RepositoryException: Exception
    {

        public RepositoryException(string message): base(message)
        {

        }

    }
}
