using Microsoft.AspNetCore.Mvc;
using Puc.Clean.Livraria.Application;
using Puc.Clean.Livraria.Application.UseCases.Common;
using Puc.Clean.Livraria.Application.UseCases.ListBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.ListBooks
{
    public class Presenter : IOutputBoundary<ListBooksOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public ListBooksOutput Output { get; private set; }

        public void Populate(ListBooksOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new Model(Output));
        }
    }
}
