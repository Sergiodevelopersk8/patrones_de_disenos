using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterPrototypeExample
{
    public abstract class Monster : IClonable
    {
      

        public string Id { get; set; }
        public string Name { get; set; }

        public abstract void Attack();
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }



    }

       
    
}
