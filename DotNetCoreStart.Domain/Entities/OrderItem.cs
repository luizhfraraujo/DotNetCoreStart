using System;
namespace DotNetCoreStart.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; private set; }
        public Product Product { get; set; }
        public int Amout { get; set; }

         public OrderItem() 
        {
            Id = Guid.NewGuid();
        }
    }
}