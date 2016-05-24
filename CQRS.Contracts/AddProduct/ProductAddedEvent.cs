﻿using System;

namespace CQRS.Contracts.AddProduct
{
    public class ProductAddedEvent : EventBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal InititalQuantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
