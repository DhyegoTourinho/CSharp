using System;
using Enumeracoes.Entitites;
using Enumeracoes.Entitites.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entitites.Enums.OrderStatus.PendingPaymant
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPaymant.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }

    }
}
