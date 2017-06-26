using System;
using System.Collections.Generic;

namespace DotNetCoreStart.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Customer Customer {get; set;}
        private DateTime CreateDate {get; set;}
        public List<OrderItem> Items { get; private set;}

        public Order() 
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.Now;
            Items = new List<OrderItem>();
        }
    }
}