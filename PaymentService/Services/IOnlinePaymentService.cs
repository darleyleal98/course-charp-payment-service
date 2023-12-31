﻿using System;

namespace PaymentService.Services
{
    public interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
