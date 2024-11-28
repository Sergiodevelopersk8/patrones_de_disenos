using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample1
{
    public class Square : Shape
    {
        public Square()
        {
            Name = "square";
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a shape with id {Id}.");
        }
    }
}
