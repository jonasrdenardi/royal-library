using RoyalLibrary.Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.Cache
{
    public interface ICache
    {
        public void AddInsertBook(object sender, Book book);
    }
}
