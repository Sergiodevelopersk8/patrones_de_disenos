using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1.Products
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the bike");
        }

        public void Start()
        {
            Console.WriteLine("Starting the bike");
            
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the bike");
            
        }
    }
}
