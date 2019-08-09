using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.CreateBook
{
    public class Model
    {
        public string BookName { get; set; }

        public Model(string bookName)
        {
            BookName = bookName;
        }
    }
}
