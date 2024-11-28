using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1.Products
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the car");
        }

        public void Start()
        {
            Console.WriteLine("Starting the car");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car");
        }
    }
}
