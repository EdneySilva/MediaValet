using System;

namespace MediaValet.Core
{
    public class Confirmation
    {
        public Guid OrderId { get; set; }
        public Guid AgentId { get; set; }
        public string OrderStatus { get; set; }
    }
}
