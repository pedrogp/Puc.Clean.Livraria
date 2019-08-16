using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.CreateBook
{
    public class CreateBookRequest
    {
        public string BookName { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
