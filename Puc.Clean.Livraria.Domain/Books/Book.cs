using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Domain.Books
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }

        public Book()
        {

        }

        public Book(string bookName, string isbn, string authors, double price)
            : this()
        {
            this.Name = bookName;
            this.Isbn = isbn;
            this.Author = authors;
            this.Price = price;
        }
    }
}
