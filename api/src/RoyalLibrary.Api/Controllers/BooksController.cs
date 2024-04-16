using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RoyalLibrary.Application.Commands.InsertBook;
using RoyalLibrary.Application.Queries.GetBooks;
using System.Threading;
using System.Threading.Tasks;

namespace RoyalLibrary.Api.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : Controller
    {
        public IMediator Mediator { get; set; }

        public BooksController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet]
        public async Task<GetBooksResponse> GetBooks([FromQuery] GetBooksRequest req, CancellationToken cancellationToken)
        {
            var resp = await Mediator.Send(req, cancellationToken);

            HttpContext.Response.StatusCode = resp.StatusCode;

            return resp;
        }

        [HttpPost]
        public async Task<InsertBookResponse> InsertBook([FromBody] InsertBookRequest req, CancellationToken cancellationToken)
        {
            var resp = await Mediator.Send(req, cancellationToken);

            HttpContext.Response.StatusCode = resp.StatusCode;

            return resp;
        }
    }
}