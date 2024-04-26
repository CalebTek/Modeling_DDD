﻿using Domain.Customers;
using Domain.Products;

namespace Domain.Orders
{
    public class Order
    {
        private readonly HashSet<LIneItem> _lineItems = new();

        private Order() { }

        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }

        public static Order Create(Customer customer)
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id
            };

            return order;
        }

        public void Add(Product product)
        {
            var lineItem = new LIneItem(Guid.NewGuid(), Id, product.Id, product.Price);
        }

    }
}
