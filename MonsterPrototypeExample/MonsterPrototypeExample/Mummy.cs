using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterPrototypeExample
{
    public class Mummy:Monster
    {

        public int Bandage { get; set; }

        public override void Attack()
        {
            Console.WriteLine($"Mummy {Id} ({Name}) attacks with {Bandage} bandage points");
        }
    }
}
