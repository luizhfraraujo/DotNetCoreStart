using System;
namespace DotNetCoreStart.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Customer() 
        {
            Id = Guid.NewGuid();
        }
    }
}