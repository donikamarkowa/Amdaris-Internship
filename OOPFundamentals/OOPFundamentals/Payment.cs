using System;

namespace OOPFundamentalsDiagram
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WokroutId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = null!;
    }
}
