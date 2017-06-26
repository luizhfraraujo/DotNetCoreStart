using System;
using DotNetCoreStart.Domain.Entities;

namespace DotNetCoreStart.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            System.Console.WriteLine("Digite o nome do cliente: ");
            customer.Name = System.Console.ReadLine();

            System.Console.WriteLine($"O cliente {customer.Name} possui o Id {customer.Id}");

            Order order = new Order();

            order.Customer = customer;
        }
    }
}
