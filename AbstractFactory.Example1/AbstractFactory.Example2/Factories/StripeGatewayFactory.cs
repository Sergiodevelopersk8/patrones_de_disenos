using AbstractFactory.Example2.ConcretClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.Factories
{
    public class StripeGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new StripeGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new StripeTransactionLogger();
        }
    }
}
