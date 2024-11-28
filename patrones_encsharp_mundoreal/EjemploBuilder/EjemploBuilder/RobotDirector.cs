using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBuilder
{
    //director
    public  class RobotDirector
    {
        private IRobotBuilder _robotBuilder;

        public RobotDirector(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public void ConstructorRobot()
        {
            _robotBuilder.BuildHead("Round");
            _robotBuilder.BuildBody("Metal");
            _robotBuilder.BuildArms("Claws");
            _robotBuilder.BuildLegs("Wheels");
        }

    }
}
