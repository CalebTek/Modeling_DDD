using MediatR;
using Persistence;

namespace Application.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly ApplicationDbContext _context;

        public CreateOrderCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
           var customer = await _context.Customers.Fin
        }
    }
}
