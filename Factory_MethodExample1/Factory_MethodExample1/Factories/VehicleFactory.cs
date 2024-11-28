using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        public IVehicle OrderVehicle()
        {
            IVehicle vehicle = CreateVehicle();

            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
            return vehicle;
        }


    }
}
