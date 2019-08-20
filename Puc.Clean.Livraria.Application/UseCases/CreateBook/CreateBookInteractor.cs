using Puc.Clean.Livraria.Application.Repositories;
using Puc.Clean.Livraria.Application.UseCases.Common;
using Puc.Clean.Livraria.Domain.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Application.UseCases.CreateBook
{
    public class CreateBookInteractor : IInputBoundary<CreateBookInput>
    {
        private readonly IBookReadOnlyRepository bookReadOnlyRepository;
        private readonly IBookWriteOnlyRepository bookWriteOnlyRepository;
        private readonly IOutputBoundary<BookOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public CreateBookInteractor(
            IBookReadOnlyRepository bookReadOnlyRepository,
            IBookWriteOnlyRepository bookWriteOnlyRepository,
            IOutputBoundary<BookOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.bookReadOnlyRepository = bookReadOnlyRepository;
            this.bookWriteOnlyRepository = bookWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(CreateBookInput input)
        {
            Book book = bookReadOnlyRepository.Select(input.Isbn);
            if (book != null)
                throw new BookAlreadyExistsException($"The book {input.Isbn} already exists.");

            Book newNook = new Book(
                input.BookName, 
                input.Isbn, 
                input.Author, 
                input.Price);

            bookWriteOnlyRepository.Insert(newNook);

            var output = outputConverter.Map<BookOutput>(newNook);

            outputBoundary.Populate(output);
        }
    }
}
