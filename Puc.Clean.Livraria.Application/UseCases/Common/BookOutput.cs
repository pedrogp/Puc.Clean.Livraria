using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Application.UseCases.Common
{
    public class BookOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }

        public BookOutput()
        {

        }

        public BookOutput(int id, string name, string isbn)
            : this()
        {
            Id = id;
            Name = name;
            Isbn = isbn;
        }
    }
}
