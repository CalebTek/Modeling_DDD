using MediatR;

namespace Application.Orders.Create
{
    public class CreateOrderCommand : IRequest
    {
        public Guid CustomerId { get; set; } 
    }
}
