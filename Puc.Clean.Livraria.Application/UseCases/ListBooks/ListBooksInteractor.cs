using Puc.Clean.Livraria.Application.Repositories;
using Puc.Clean.Livraria.Application.UseCases.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Clean.Livraria.Application.UseCases.ListBooks
{
    public class ListBooksInteractor : IInputBoundary<ListBooksInput>
    {
        private readonly IBookReadOnlyRepository bookReadOnlyRepository;
        private readonly IOutputBoundary<ListBooksOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public ListBooksInteractor(
            IBookReadOnlyRepository bookReadOnlyRepository,
            IOutputBoundary<ListBooksOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.bookReadOnlyRepository = bookReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(ListBooksInput input)
        {
            var books = bookReadOnlyRepository.Select();

            var booksOutput = books.Select(book => outputConverter.Map<BookOutput>(book));
            ListBooksOutput output = new ListBooksOutput(booksOutput);

            outputBoundary.Populate(output);
        }
    }
}