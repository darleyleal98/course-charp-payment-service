using System;


namespace PaymentService.Entities
{
    public class Contract
    {
        public int Number {  get; set; }
        public DateTime Date {  get; set; }
        public Double TotalValue { get; set; }
        List<Installment> Installments;

        public Contract(int number, DateTime dateTime, double totalValue)
        {
            Number = number;
            Date = dateTime;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddInstallment(Installment installment) => Installments.Add(installment);
    }
}