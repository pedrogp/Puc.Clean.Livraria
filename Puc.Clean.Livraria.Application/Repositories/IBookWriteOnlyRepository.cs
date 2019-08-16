using Puc.Clean.Livraria.Domain.Books;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Application.Repositories
{
    public interface IBookWriteOnlyRepository
    {
        Task Add(Book book);
        void Remove(Book book);
        Task Update(Book book);
    }
}
