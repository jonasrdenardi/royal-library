using MediatR;
using RoyalLibrary.Domain.Enum;

namespace RoyalLibrary.Application.Queries.GetBooks
{
    public class GetBooksRequest : IRequest<GetBooksResponse>
    {
        public SearchBook SearchBookBy { get; set; }
        public string SearchBookValue { get; set; }
    }
}