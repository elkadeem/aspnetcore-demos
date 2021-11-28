using System.ComponentModel.DataAnnotations;

namespace EFDemo
{
    public class OrderItem
    {
        [Key]
        public int OrderId { get; set; }

        [Key]
        public int Serial { get; set; }

        public string Item { get; set; }

        public double Amount { get; set; }

        public double Price { get; set; }

        public double? Discount { get; set; }
    }
}
