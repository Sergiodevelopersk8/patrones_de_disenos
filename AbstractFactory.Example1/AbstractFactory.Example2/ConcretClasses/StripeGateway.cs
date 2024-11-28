using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.ConcretClasses
{
    public class StripeGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} with PayPal");
            return true;
        }
    }
}
