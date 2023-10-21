using System;


namespace PaymentService.Entities
{
    public class Contract
    {
        private int Number {  get; set; }
        private DateTime Date {  get; set; }
        private Double TotalValue { get; set; }
        List<Installment> installments = new List<Installment> { };

        public Contract(int number, DateTime dateTime, double totalValue)
        {
            Number = number;
            Date = dateTime;
            TotalValue = totalValue;
        }
    }
}
