using System;
using System.Collections.Generic;
using System.Text;
using ExerciceI.Entities;

namespace ExerciceI.Services
{
    class ContractService
    {
        private IOnlinePaimentService _onlinePaimentService;

        public ContractService(IOnlinePaimentService onlinePaimentService)
        {
            _onlinePaimentService = onlinePaimentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(1);
                double updateQuota = basicQuota + _onlinePaimentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaimentService.PaymentFee(updateQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
