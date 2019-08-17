using Puc.Clean.Livraria.Application.Repositories;
using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Infrastructure.DataAccess
{
    public class BookRepository : BaseRepository<Book>, IBookReadOnlyRepository, IBookWriteOnlyRepository
    {
        private readonly BookStoreContext context;

        public BookRepository(BookStoreContext context)
        {
            this.context = context;
        }

        public Book Select(string isbn)
        {
            return context
                .Books
                .FirstOrDefault(e => e.Isbn == isbn);
        }
    }
}
