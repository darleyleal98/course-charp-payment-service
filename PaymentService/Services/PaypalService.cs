using System;

namespace PaymentService.Services
{
    public class PaypalService : OnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            double value = amount / months;
            return value +
        }

        public double PaymentFee(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
