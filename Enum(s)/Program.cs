using Enum_s_.Entities;
using Enum_s_.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = Enum_s_.Entities.Enums.OrderStatus.PendingPayment

};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(txt);

