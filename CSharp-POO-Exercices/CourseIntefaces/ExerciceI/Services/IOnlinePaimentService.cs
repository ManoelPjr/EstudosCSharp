using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceI.Services
{
    interface IOnlinePaimentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
