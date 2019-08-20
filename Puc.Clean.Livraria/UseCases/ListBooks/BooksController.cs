using Microsoft.AspNetCore.Mvc;
using Puc.Clean.Livraria.Application;
using Puc.Clean.Livraria.Application.UseCases.ListBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.UseCases.ListBooks
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IInputBoundary<ListBooksInput> listBooksInput;
        private readonly Presenter listBooksPresenter;

        public BooksController(
            IInputBoundary<ListBooksInput> createBookInput,
            Presenter createBookPresenter)
        {
            this.listBooksInput = createBookInput;
            this.listBooksPresenter = createBookPresenter;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new ListBooksInput();

            await listBooksInput.Process(request);
            return listBooksPresenter.ViewModel;
        }
    }
}
