using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Application.Repositories
{
    public interface IBookReadOnlyRepository
    {
        Task<Book> Get(string isbn);
        Task<Book> Get(int id);
    }
}
