using System;
using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuote = contract.totalValue / months;

            for (int i = 1; i <= months; i++)
            {
                //Adiciona um mês a data já existente.
                DateTime date = contract.date.AddMonths(i);

                double updatedQuota = basicQuote + _onlinePaymentService.Interest(basicQuote, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(basicQuote);

                contract.addInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
