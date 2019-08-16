using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Application.UseCases.CreateBook
{
    public class CreateBookOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }

        public CreateBookOutput(string bookName)
        {
            Name = bookName;
        }
    }
}
