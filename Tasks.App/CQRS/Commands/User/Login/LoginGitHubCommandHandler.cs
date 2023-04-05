﻿using MediatR;

namespace Tasks.App.CQRS.Commands.User.Login
{
    public class LoginGitHubCommandHandler : IRequestHandler<LoginGitHubCommand, LoginCommandResult>
    {
        public async Task<LoginCommandResult> Handle(LoginGitHubCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
