﻿using Domain.Products;
using Domain.Shared;

namespace Domain.Orders
{
    public class LineItem
    {
        internal LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;  
        }
        private LineItem() { } // For EF

        public LineItemId Id { get; private set; }
        public OrderId OrderId { get; private set; }
        public ProductId ProductId { get; private set; }
        public Money Price { get; private set; }
    }
}