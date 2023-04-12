using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tasks.App.CQRS.Queries.Tokens.ReadToken;
using Tasks.Domain.Models;

namespace Tasks.Angular.Controllers
{
    public abstract class BaseAuthController : ControllerBase
    {
        protected readonly IMediator _mediator;

        protected BaseAuthController(IMediator mediator)
        {
            _mediator = mediator;
        }


        protected async Task<User?> ValidateUserByToken(int userId)
        {
            var token = Request.Headers.Authorization.FirstOrDefault();

            if (!string.IsNullOrEmpty(token) && token.StartsWith("Bearer "))
            {
                var tokenData = token.Replace("Bearer ", "");
                var userRes = await _mediator.Send(new ReadTokenQuery(tokenData));
                if (userRes != null && userRes.User.Id.Equals(userId))
                {
                    return userRes.User;
                }
            }

            return null;
        }
    }
}
