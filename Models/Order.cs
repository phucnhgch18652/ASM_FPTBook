﻿namespace FPTBook.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDate { get; set;}
    }
}
