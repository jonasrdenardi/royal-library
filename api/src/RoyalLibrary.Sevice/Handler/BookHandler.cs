using RoyalLibrary.Domain.Entitie;
using RoyalLibrary.Domain.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Sevice.Handler
{
    public class BookHandler : IBookHandler
    {
        public event EventHandler<Book> InserBook;

        public void InsertBookInvoke(Book book)
        {
            InserBook?.Invoke(this, book);
        }
    }
}
