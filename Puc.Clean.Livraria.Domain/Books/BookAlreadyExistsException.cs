using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Domain.Books
{
    public class BookAlreadyExistsException : DomainException
    {
        public BookAlreadyExistsException(string message)
            : base(message)
        { }
    }
}
