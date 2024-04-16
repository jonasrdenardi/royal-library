using MediatR;
using RoyalLibrary.Domain.Entitie;
using RoyalLibrary.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalLibrary.Application.Commands.InsertBook
{
    public static class InsertBookAdapter
    {
        public static Book Adapt(InsertBookRequest req)
        {
            return new Book
            {
                Category = req.Category,
                FirstName = req.FirstName,
                LastName = req.LastName,
                ISBN = req.ISBN,
                Title = req.Title,
                Type = req.Type,
                TotalCopies = req.TotalCopies,
                CopiesInUse = 0,
            };
        }
    }
}