using MediatR;

namespace Api.Customers.Features
{
    public static class CreateContact
    {
        public class Command : IRequest<Response>
        {

        }

        public class Response
        {

        }

        public class Handler : IRequestHandler<Command, Response>
        {
            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
