using AbstractFactory.Example2.ConcretClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.Factories
{
    public class PayPalGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
        return new PayPalGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new PayPalTransactionLogger();
        }
    }
}
