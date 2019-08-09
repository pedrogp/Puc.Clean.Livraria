using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Application.UseCases.CreateBook
{
    public class CreateBookOutput
    {
        public string BookName { get; set; }

        public CreateBookOutput(string bookName)
        {
            BookName = bookName;
        }
    }
}
