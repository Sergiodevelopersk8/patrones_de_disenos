using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodejercicio2.Products
{
    internal class EmailNotification : INotification
    {
        public void send(string message)
        {
          Console.WriteLine($"Sending email notification: {message}");
        }
    }
}
