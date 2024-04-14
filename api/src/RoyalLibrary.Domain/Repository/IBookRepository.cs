using RoyalLibrary.Domain.Entitie;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.Repository
{
    public interface IBookRepository
    {
        Task<Book> InserirAsync(Book curso);
        Task<IList<Book>> GetAsync(Enum.SearchBook searchBookBy, string searchBookValue);
        Task<Book> GetByIdAsync(int id);
        void Update(Book curso);
        void Delete(Book curso);
    }
}