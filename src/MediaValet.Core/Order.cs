using System;

namespace MediaValet.Core
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public int RandomNumber { get; set; }
        public string OrderText { get; set; }
    }
}
