using MediatR;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Domain.Util;
using System;
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

                Resp.Books = books;
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