using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MonsterPrototypeExample
{
    public class Zombie : Monster
    {

        public int Health { get; set; }





        public override void Attack()
        {
            Console.WriteLine($"Zombie {Id} ({Name}) attacks with {Health} health points");
        }


    } 

       
    
}
