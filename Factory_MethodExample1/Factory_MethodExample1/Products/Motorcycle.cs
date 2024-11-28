using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1.Products
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the Motorcycle");
        }

        public void Start()
        {
            Console.WriteLine("Starting the Motorcycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the Motorcycle");
        }
    }
}
