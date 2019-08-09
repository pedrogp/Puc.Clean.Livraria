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
        private readonly IOutputBoundary<CreateBookOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public DepositInteractor(
            IBookReadOnlyRepository bookReadOnlyRepository,
            IBookWriteOnlyRepository bookWriteOnlyRepository,
            IOutputBoundary<CreateBookOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.bookReadOnlyRepository = bookReadOnlyRepository;
            this.bookWriteOnlyRepository = bookWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(CreateBookInput input)
        {
            Book book = await bookReadOnlyRepository.Get(input.Isbn);
            if (book != null)
                throw new BookNotFoundException($"The book {input.Isbn} already exists.");

            Book newNook = new Book(
                input.BookName, 
                input.Isbn, 
                input.Authors, 
                input.Price);

            book.Create();

            await bookWriteOnlyRepository.Update(book);

            TransactionOutput transactionResponse = outputConverter.Map<TransactionOutput>(credit);
            DepositOutput output = new DepositOutput(transactionResponse, account.GetCurrentBalance().Value);

            CreateBookOutput output = new CreateBookOutput(book.Name);

            outputBoundary.Populate(output);
        }
    }
}
