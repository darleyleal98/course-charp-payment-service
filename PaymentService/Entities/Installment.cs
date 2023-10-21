using System;

namespace PaymentService.Entities
{
    public class Installment
    {
        private DateTime Duedate {  get; set; }
        private double Amount { get; set; }
    }
}
