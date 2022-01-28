using MediatR;

namespace Api.Orders
{
    internal static class CreateNewCase
    {
        class Command : IRequest<Response> { }

        class Response { }

        class CommandHandler : IRequestHandler<Command, Response>
        {
            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
