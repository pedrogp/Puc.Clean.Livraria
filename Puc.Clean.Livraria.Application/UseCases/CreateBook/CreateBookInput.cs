using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Application.UseCases.CreateBook
{
    public class CreateBookInput
    {
        public string BookName { get; set; }
        public string Isbn { get; set; }
        public string[] Authors { get; set; }
        public double Price { get; set; }
    }
}
