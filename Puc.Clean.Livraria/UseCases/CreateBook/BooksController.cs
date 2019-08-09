using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Puc.Clean.Livraria.Application;
using Puc.Clean.Livraria.Application.UseCases.CreateBook;

namespace Puc.Clean.Livraria.UseCases.CreateBook
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IInputBoundary<CreateBookInput> createBookInput;
        private readonly Presenter createBookPresenter;

        public BooksController(
            IInputBoundary<CreateBookInput> createBookInput,
            Presenter createBookPresenter)
        {
            this.createBookInput = createBookInput;
            this.createBookPresenter = createBookPresenter;
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]CreateBookRequest message)
        {
            var request = new CreateBookInput
            {
                BookName = message.BookName,
                Authors = message.Authors,
                Isbn = message.Isbn,
                Price = message.Price,
            };

            await createBookInput.Process(request);
            return createBookPresenter.ViewModel;
        }
    }
}