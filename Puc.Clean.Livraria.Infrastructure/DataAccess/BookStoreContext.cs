using Microsoft.EntityFrameworkCore;
using Puc.Clean.Livraria.Domain.Books;
using Puc.Clean.Livraria.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.DataAccess
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("DataSource=app.db");

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(new BookMap().Configure);
        }
    }
}
