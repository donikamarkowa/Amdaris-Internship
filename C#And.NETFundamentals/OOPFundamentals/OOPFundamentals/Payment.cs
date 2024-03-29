using OOPFundamentals;
using System;

namespace OOPFundamentalsDiagram
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Workout Workout { get; set; } = null!;
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = null!;
    }
}
