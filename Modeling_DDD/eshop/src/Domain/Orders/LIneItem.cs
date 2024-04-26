﻿using Domain.Products;
using Domain.Shared;

namespace Domain.Orders
{
    public class LIneItem
    {
        internal LIneItem(LIneItemId id, OrderId orderId, ProductId productId, Money price)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
        }

        public LIneItemId Id { get; private set; }
        public OrderId OrderId { get; private set; }
        public ProductId ProductId { get; private set; }
        public Money Price { get; private set; }
    }
}