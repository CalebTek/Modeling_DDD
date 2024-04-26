using Domain.Customers;
using Domain.Products;
using Domain.Shared;

namespace Domain.Orders
{
    // Aggregate
    public class Order
    {
        private readonly HashSet<LIneItem> _lineItems = new();

        private Order() { }

        public OrderId Id { get; private set; }
        public CustomerId CustomerId { get; private set; }
        public OrderStatus Status { get; private set; }

        public IReadOnlyList<LIneItem > LineItems => _lineItems.ToList();

        public static Order Create(CustomerId customerId)
        {
            var order = new Order()
            {
                Id = new OrderId(Guid.NewGuid()),
                CustomerId = customerId,
                Status = OrderStatus.Pending
            };

            return order;
        }

        public void Add(ProductId productId, Money price)
        {
            var lineItem = new LIneItem(new LIneItemId(Guid.NewGuid()), Id, productId, price);

            _lineItems.Add(lineItem);
        }

    }
}
