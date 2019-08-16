using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
              .IsRequired()
              .HasColumnName("Name");

            builder.Property(c => c.Isbn)
              .IsRequired()
              .HasColumnName("Isbn");

            builder.Property(c => c.Price)
              .IsRequired()
              .HasColumnName("Isbn");

            builder.Property(c => c.CreateDate)
              .IsRequired()
              .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
