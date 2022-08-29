using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Entities
{
    public class Order
    {
        public Order(DateTime moment, string orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public DateTime Moment { get; set; }
        public string OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItems(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemoveItems(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
    }
}
