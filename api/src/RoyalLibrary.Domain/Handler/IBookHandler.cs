using RoyalLibrary.Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.Handler
{
    public interface IBookHandler
    {
        public event EventHandler<Book> InserBook;
        public void InsertBookInvoke(Book book);
    }
}
