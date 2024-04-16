using MediatR;
using RoyalLibrary.Application.Queries.GetBooks;
using RoyalLibrary.Domain.Cache;
using RoyalLibrary.Domain.DTO;
using RoyalLibrary.Domain.Handler;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Domain.Util;
using RoyalLibrary.Sevice.Handler;
using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace RoyalLibrary.Application.Commands.InsertBook
{
    public class InsertBookCommand : IRequestHandler<InsertBookRequest, InsertBookResponse>
    {
        InsertBookResponse Resp = new();
        IBookRepository BookRepository { get; }
        Domain.Notification.INotification Notification { get; }
        ICache Cache { get; }
        IBookHandler BookHandler { get; }

        public InsertBookCommand(IBookRepository bookRepository, Domain.Notification.INotification notification, ICache cache, IBookHandler bookHandler)
        {
            BookRepository = bookRepository;
            Notification = notification;
            Cache = cache;
            BookHandler = bookHandler;
        }

        public async Task<InsertBookResponse> Handle(InsertBookRequest req, CancellationToken cancellationToken)
        {
            try
            {
                var book = InsertBookAdapter.Adapt(req);

                book = await BookRepository.InserirAsync(book);

                BookHandler.InserBook += Cache.AddInsertBook;
                BookHandler.InserBook += Notification.SendInsertBook;

                BookHandler.InsertBookInvoke(book);

                Resp.Book = book;
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