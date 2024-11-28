using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_MethodExample1
{
    public interface IVehicle
    {
        public void Start();
        public void Stop();
        public void Drive();
    }
}
