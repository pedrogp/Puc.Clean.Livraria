using Puc.Clean.Livraria.Application.UseCases.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Clean.Livraria.Application.UseCases.ListBooks
{
    public class ListBooksOutput
    {
        public BookOutput[] Books { get; set; }

        public ListBooksOutput()
        {

        }

        public ListBooksOutput(IEnumerable<BookOutput> books)
        {
            Books = books.ToArray();
        }
    }
}
