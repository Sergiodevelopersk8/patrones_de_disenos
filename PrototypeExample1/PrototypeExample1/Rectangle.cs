using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample1
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Name = "Rectangle";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with id {Id}."); ;
        }
    }
}
