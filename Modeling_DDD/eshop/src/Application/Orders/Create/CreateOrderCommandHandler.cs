﻿using Domain.Customers;
using Domain.Orders;
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
           var customer = await _context.Customers.FindAsync(new CustomerId(request.CustomerId));

            if (customer == null)
            {
                return;
            }

            var order = Order.Create(customer.Id);

            _context.Orders.Add(order);

            await _context.SaveChangesAsync();
        }
    }
}
