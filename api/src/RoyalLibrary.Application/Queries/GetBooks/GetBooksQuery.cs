using MediatR;
using RoyalLibrary.Domain.Cache;
using RoyalLibrary.Domain.DTO;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Domain.Util;
using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace RoyalLibrary.Application.Queries.GetBooks
{
    public class GetBooksQuery : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        GetBooksResponse Resp = new();
        IBookRepository BookRepository { get; }

        public GetBooksQuery(IBookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public async Task<GetBooksResponse> Handle(GetBooksRequest req, CancellationToken cancellationToken)
        {
            try
            {
                var books = await BookRepository.GetAsync(req.SearchBookBy, req.SearchBookValue);

                var booksDto = books.Select(x => new BookDTO(x)).ToList();

                Resp.Books = booksDto;
                Resp.StatusCode = (int)HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Resp.Messages.Add(ex.GetAllMessages());
                Resp.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            return Resp;
        }
    }
}