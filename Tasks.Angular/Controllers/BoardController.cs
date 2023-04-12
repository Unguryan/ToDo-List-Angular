using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tasks.App.CQRS.Commands.Boards.CreateBoard;
using Tasks.App.CQRS.Queries.Boards.GetUserBoardById;
using Tasks.App.CQRS.Queries.Boards.GetUserBoards;

namespace Tasks.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardController : BaseAuthController
    {
        public BoardController(IMediator mediator) : base(mediator)
        {
        }


        [HttpGet]
        [Route("{userId}")]
        public async Task<GetUserBoardsQueryResult> GetBoards(string userId)
        {
            //TODO: Remove It, and add new Middleware for auth users
            //var user = await ValidateUserByToken(int.Parse(userId));
            //if(user == null)
            //{
            //    return new GetUserBoardsQueryResult(null);
            //}

            return await _mediator.Send(new GetUserBoardsQuery(int.Parse(userId)));
        }

        [HttpGet]
        [Route("{userId}/{boardId}")]
        public async Task<GetUserBoardByIdQueryResult> GetBoards(string userId, string boardId)
        {
            //var user = await ValidateUserByToken(int.Parse(userId));
            //if (user == null)
            //{
            //    return new GetUserBoardByIdQueryResult(false, null);
            //}

            return await _mediator.Send(new GetUserBoardByIdQuery(int.Parse(userId), int.Parse(boardId)));
        }

        [HttpPost]
        [Route("create")]
        public async Task<CreateBoardCommandResult> AddBoard([FromBody] CreateBoardCommand body)
        {
            return await _mediator.Send(body);
        }
    }
}
