using Api.Customers.Domain;
using MediatR;

namespace Api.Customers.Features
{
    public static class CreateCustomer
    {
        public class Command : IRequest<Response>
        {
            public string? Name { get; set; }
        }

        public class Response
        {
            public Guid Id { get; private set; }

            public Response(Guid Id)
            {
                this.Id = Id;
            }
        }

        public class CommandHandler : IRequestHandler<Command, Response>
        {
            private CustomersDbContext? _context;

            public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                _context = new CustomersDbContext();

                await _context.Database.EnsureCreatedAsync(cancellationToken);

                var newCustomer = new Customer(Guid.NewGuid());

                _context.Customers.Add(newCustomer);

                await _context.SaveChangesAsync();

                return new Response(newCustomer.Id);
            }
        }
    }
}
