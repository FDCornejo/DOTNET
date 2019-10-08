using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        //public string Status { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public IList<OrderProduct> OrderProducts { get; set; }
    }
}
