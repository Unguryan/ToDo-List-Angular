using MediatR;

namespace Tasks.App.CQRS.Queries.Token.ReadToken
{
    public class ReadTokenQueryHandler : IRequestHandler<ReadTokenQuery, ReadTokenQueryResult>
    {
        public async Task<ReadTokenQueryResult> Handle(ReadTokenQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
