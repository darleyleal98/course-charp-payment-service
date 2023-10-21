using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Text;

namespace PaymentService.Entities
{
    public class Installment
    {
        private DateTime DueDate {  get; set; }
        private double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{DueDate.ToString("dd/MM/yyyy")} - {Amount:c}");
            return stringBuilder.ToString();
        }
    }
}