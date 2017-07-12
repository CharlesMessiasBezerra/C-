using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModerStore.Domain.Entities;

namespace ModerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Charles","Messias");
            var customer = new Customer("Charles", "Messias", "charlesgeek@gmail.com", user);
            var mouse = new Product("Mouse", 299, "Mouse.jpg", 5);
            var mousePad = new Product("Mouse Pad", 99, "Mouse.jpg", 7);
            var teclado = new Product("Mouse Teclado", 599, "Mouse.jpg", 2);


            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse,2,299));
            order.AddItem(new OrderItem(mousePad,3, 99));
            order.AddItem(new OrderItem(teclado,1, 599));

            Console.WriteLine($"Numero do pedido: {order.Number}");
            Console.WriteLine($"Data: {order.CreateDate:dd/mm/yyyy}");
            Console.WriteLine($"Desconto: {order.Discount}");
            Console.WriteLine($"Taxa de Entrega: {order.DeliveryFee}");
            Console.WriteLine($"Sub Total: {order.SubTotal() }");
            Console.WriteLine($"Total: {order.Total()}");
            Console.WriteLine($"Cliente: {order.Customer.ToString()}");

            Console.ReadKey();
        }
    }
}
