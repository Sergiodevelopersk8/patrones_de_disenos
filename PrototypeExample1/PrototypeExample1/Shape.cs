using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample1
{
    public abstract class Shape : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Draw();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
