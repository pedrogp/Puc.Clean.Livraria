using Puc.Clean.Livraria.Domain.Books;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Application.Repositories
{
    public interface IBookWriteOnlyRepository
    {
        Task Insert(Book obj);
        void Update(Book obj);
        Task Delete(int id);
    }
}
