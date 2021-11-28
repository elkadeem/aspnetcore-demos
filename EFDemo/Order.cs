using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        public double Amount { get; set; }

        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
