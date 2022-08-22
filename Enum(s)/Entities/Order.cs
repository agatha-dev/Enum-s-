using System;
using Enum_s_.Entities.Enums;

namespace Enum_s_.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", "
                + Moment 
                + ", "
                + Status;
        }


    }
}
