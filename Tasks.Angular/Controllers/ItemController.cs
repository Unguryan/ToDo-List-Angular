using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemState;
using Tasks.App.CQRS.Commands.Items.CreateItem;

namespace Tasks.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : BaseAuthController
    {
        public ItemController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost]
        [Route("create")]
        public async Task<CreateItemCommandResult> AddItemToBoard([FromBody] CreateItemCommand body)
        {
            //var user = await ValidateUserByToken(int.Parse(body.));
            //if (user == null)
            //{
            //    return new GetUserBoardsQueryResult(null);
            //}

            return await _mediator.Send(body);
        }

        [HttpPost]
        [Route("change/state")]
        public async Task<ChangeItemStateCommandResult> ChangeItemState([FromBody] ChangeItemStateCommand body)
        {
            //var user = await ValidateUserByToken(int.Parse(body.));
            //if (user == null)
            //{
            //    return new GetUserBoardsQueryResult(null);
            //}

            return await _mediator.Send(body);
        }
    }
}
