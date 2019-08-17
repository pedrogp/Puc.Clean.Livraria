using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Insert(T obj);

        void Update(T obj);

        Task Delete(int id);

        Task<T> Select(int id);

        IList<T> Select();
    }
}
