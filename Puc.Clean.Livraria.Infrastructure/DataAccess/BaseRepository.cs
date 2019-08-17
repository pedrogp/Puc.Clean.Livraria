using Puc.Clean.Livraria.Domain;
using Puc.Clean.Livraria.Domain.Interfaces;
using Puc.Clean.Livraria.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Infrastructure.DataAccess
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private BookStoreContext context = new BookStoreContext();

        public async Task Insert(T obj)
        {
            await context.Set<T>().AddAsync(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            context.Set<T>().Remove(await Select(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public async Task<T> Select(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }
    }
}
