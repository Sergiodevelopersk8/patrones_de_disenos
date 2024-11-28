using Factory_MethodExample1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1.Factories
{
    public class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}
