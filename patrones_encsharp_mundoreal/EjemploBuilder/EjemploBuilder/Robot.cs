using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBuilder
{
    /*Product*/
    public  class Robot
    {
        public string Head { get; set; }
        public string Body{ get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }

        public void DisplayRobotInfo()
        {
            Console.WriteLine("Robot Info");
            Console.WriteLine($"Head: {Head}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Arms: {Arms}");
            Console.WriteLine($"Legs: {Legs}");
            
        }

    }
}
