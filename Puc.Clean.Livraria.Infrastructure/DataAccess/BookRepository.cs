using Puc.Clean.Livraria.Application.Repositories;
using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Infrastructure.DataAccess
{
    public class BookRepository : IBookReadOnlyRepository, IBookWriteOnlyRepository
    {
        private readonly BookStoreContext context;

        public BookRepository(BookStoreContext context)
        {
            this.context = context;
        }

        public async Task Add(Book book)
        {
            await context.Books.AddAsync(book);
        }

        public void Remove(Book book)
        {
            context.Books.Remove(book);
        }

        public async Task<Book> Get(int id)
        {
            return await context
                .Books
                .FindAsync(id);
        }

        public Book Get(string isbn)
        {
            return context
                .Books
                .FirstOrDefault(e => e.Isbn == isbn);
        }

        public async Task Update(Book book)
        {
            var bookData = await Get(book.Id);
            
            if (bookData != null)
            {
                bookData = book;
            }
        }
    }
}
