using System;

namespace DotNetCoreStart.Domain.Entities
{    
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public float SalesPrice {get;set;}
        public int StockAmount {get; set;}

        public Product() 
        {
            Id = Guid.NewGuid();
        }
    }
}