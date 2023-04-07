using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.ChangeBoardName
{
    public class ChangeBoardNameCommandHandler : IRequestHandler<ChangeBoardNameCommand, ChangeBoardNameCommandResult>
    {
        public async Task<ChangeBoardNameCommandResult> Handle(ChangeBoardNameCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
