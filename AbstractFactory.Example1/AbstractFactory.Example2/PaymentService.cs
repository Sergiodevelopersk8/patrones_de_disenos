using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    public class PaymentService
    {
        private readonly IPaymentGateway _paymentGateway;
        private readonly ITransactionLogger _transactionLogger;
        public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
        {
            _paymentGateway = paymentGatewayFactory.CreatePaymentGateway();
            _transactionLogger = paymentGatewayFactory.CreateTransactionLogger();
        }
        public void ProcessPaymen(decimal amount)
        {
            if (_paymentGateway.ProcessPayment(amount))
            {
                _transactionLogger.LogTransaction($"Payment of{amount}, was successful");
            }
            else
            {
                _transactionLogger.LogTransaction($"Payment of{amount}, failed");

            }
        }
    }
}
