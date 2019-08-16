using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Domain
{
    public class DomainException : Exception
    {
        internal DomainException()
        { }

        internal DomainException(string message)
            : base(message)
        { }

        internal DomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
