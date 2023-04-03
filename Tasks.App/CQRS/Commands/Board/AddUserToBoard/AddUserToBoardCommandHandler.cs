using MediatR;

namespace Tasks.App.CQRS.Commands.Board.AddUserToBoard
{
    public class AddUserToBoardCommandHandler : IRequestHandler<AddUserToBoardCommand, AddUserToBoardCommandResult>
    {
        public async Task<AddUserToBoardCommandResult> Handle(AddUserToBoardCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
