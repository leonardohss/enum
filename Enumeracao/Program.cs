using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();/*conversão para string, incluindo na variavel */

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            /*conversão para string, necessario que o "delivered" seja 
            identico ao definido no enum*/

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
