using Puc.Clean.Livraria.Application.UseCases.ListBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.ListBooks
{
    public class Model
    {
        public BookModel[] Books { get; set; }

        public Model(ListBooksOutput books)
        {
            Books = books.Books.Select(b => new BookModel
            {
                Id = b.Id,
                Isbn = b.Isbn,
                Name = b.Name,
            }).ToArray();
        }
    }
    public class BookModel
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public int Id { get; set; }
    }
}
