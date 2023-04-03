﻿using MediatR;

namespace Tasks.App.CQRS.Commands.Item.RemoveItem
{
    public class RemoveItemCommandHandler : IRequestHandler<RemoveItemCommand, RemoveItemCommandResult>
    {
        public async Task<RemoveItemCommandResult> Handle(RemoveItemCommand request, CancellationToken cancellationToken)
        {

        }
    }
}