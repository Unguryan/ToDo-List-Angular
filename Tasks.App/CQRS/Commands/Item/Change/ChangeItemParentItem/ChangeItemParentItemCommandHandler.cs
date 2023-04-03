﻿using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemParentItem
{
    public class ChangeItemParentItemCommandHandler : IRequestHandler<ChangeItemParentItemCommand, ChangeItemParentItemCommandResult>
    {
        public async Task<ChangeItemParentItemCommandResult> Handle(ChangeItemParentItemCommand request, CancellationToken cancellationToken)
        {

        }
    }
}