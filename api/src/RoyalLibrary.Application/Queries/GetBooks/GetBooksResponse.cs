using RoyalLibrary.Domain.Base;
using RoyalLibrary.Domain.Entitie;
using System.Collections.Generic;

namespace RoyalLibrary.Application.Queries.GetBooks
{
    public class GetBooksResponse : ResponseBase
    {
        public IList<Book> Books { get; set; }
    }
}