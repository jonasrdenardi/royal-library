using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Entitie;
using RoyalLibrary.Domain.Enum;
using RoyalLibrary.Domain.Repository;
using RoyalLibrary.Infra.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalLibrary.Infra.Repository.MySql
{
    public class BookRepository : IBookRepository
    {
        public RoyalLibraryContext Context { get; set; }

        public BookRepository(RoyalLibraryContext context)
        {
            Context = context;
        }

        public async Task<Book> InserirAsync(Book book)
        {
            await Context.Book.AddAsync(book);
            await Context.SaveChangesAsync();

            return book;
        }

        public async Task<IList<Book>> GetAsync(SearchBook searchBookBy, string searchBookValue)
        {
            var value = searchBookValue?.ToUpper();

            var result = searchBookBy switch
            {
                SearchBook.Title => await Context.Book.Where(x => x.Title.ToUpper().Contains(value)).ToListAsync(),
                SearchBook.Author => await Context.Book.Where(x =>
                        x.FirstName.ToUpper().Contains(value) ||
                        x.LastName.ToUpper().Contains(value) ||
                        string.Concat(x.FirstName.ToUpper(), " ", x.LastName).Contains(value)).ToListAsync(),
                SearchBook.Type => await Context.Book.Where(x => x.Type.ToUpper().Contains(value)).ToListAsync(),
                SearchBook.ISBN => await Context.Book.Where(x => x.ISBN.ToUpper().Contains(value)).ToListAsync(),
                SearchBook.Category => await Context.Book.Where(x => x.Category.ToUpper().Contains(value)).ToListAsync(),
                _ => new List<Book>(),
            };

            return result;
        }

        public async Task<Book> GetByIdAsync(int bookId)
        {
            return await Context.Book.FirstOrDefaultAsync(x => x.BookId == bookId);
        }

        public void Update(Book book)
        {
            Context.Book.Update(book);
            Context.SaveChanges();
        }

        public void Delete(Book book)
        {
            Context.Book.Remove(book);
            Context.SaveChanges();
        }
    }
}