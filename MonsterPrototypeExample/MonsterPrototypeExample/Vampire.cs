using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterPrototypeExample
{
    public class Vampire : Monster
    {
        public int Bloodlust { get; set; }  
        public override void Attack()
        {
            Console.WriteLine($"Vampire {Id} ({Name}) attacks with {Bloodlust} bloodlust points");
        }
    }
}
