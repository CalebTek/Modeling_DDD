using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Orders.RemoveLineItem
{
   
    public class RemoveLineItemCommandHandler : IRequestHandler<RemoveLineItemCommand>
    {
        private readonly ApplicationDbContext _context;

        public RemoveLineItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveLineItemCommand request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Include(o => o.LineItems.Where(li => li.Id == request.LineItemId))
                .SingleOrDefaultAsync(o => o.Id == request.OrderId,cancellationToken);

            if (order is null)
            {
                return;
            }

            order.RemoveLineItem(request.LineItemId);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
