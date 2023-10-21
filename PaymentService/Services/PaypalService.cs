using System;

namespace PaymentService.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount) => amount * FeePercentage;
        public double Interest(double amount, int months) => amount * MonthlyInterest * months;
    }
}
