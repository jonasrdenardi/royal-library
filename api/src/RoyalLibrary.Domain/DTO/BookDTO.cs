using RoyalLibrary.Domain.Entitie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.DTO
{
    public class BookDTO
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string AvailableCopies { get; set; }

        public BookDTO(Book book)
        {
            this.Author = string.Concat(book.FirstName, " ", book.LastName);
            this.Category = book.Category;
            this.Publisher = "Publisher";
            this.ISBN = book.ISBN;
            this.Title = book.Title;
            this.Type = book.Type;
            this.AvailableCopies = $"{book.TotalCopies - book.CopiesInUse}/{book.TotalCopies}";
        }
    }
}
