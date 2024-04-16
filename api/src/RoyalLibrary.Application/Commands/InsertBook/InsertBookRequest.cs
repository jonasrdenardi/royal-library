using MediatR;
using RoyalLibrary.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalLibrary.Application.Commands.InsertBook
{
    public class InsertBookRequest : IRequest<InsertBookResponse>
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalCopies { get; set; }
        public string Type { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
    }
}