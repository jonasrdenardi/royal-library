using RoyalLibrary.Domain.Base;
using RoyalLibrary.Domain.DTO;
using RoyalLibrary.Domain.Entitie;
using System.Collections.Generic;

namespace RoyalLibrary.Application.Commands.InsertBook
{
    public class InsertBookResponse : ResponseBase
    {
        public Book Book { get; set; }
    }
}